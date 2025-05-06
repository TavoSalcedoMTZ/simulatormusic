using UnityEngine;
using System.Collections;
using UnityEngine.Events;
public class AbrirPanelConTrancision : MonoBehaviour
{
    private Transform objetoAEscalar;
    public float duracion = 0.5f;
    private Vector3 escalaObjetivo = new Vector3(0.8979599f, 0.8979599f, 0.8979599f);
    public UnityEvent eventoPanelAlAcabarTrancision;
    public UnityEvent eventoPanelAlIniciarTrancision;

    public bool EventosPermitidos;
    public void Start()
    {

        objetoAEscalar = GetComponent<Transform>();
    }
    public void Abrir()
    {
        StopAllCoroutines();
        StartCoroutine(EscalarObjeto(Vector3.zero, escalaObjetivo));
    }

    public void Cerrar()
    {
        StopAllCoroutines();
        StartCoroutine(EscalarObjeto(escalaObjetivo, Vector3.zero));
    }

    private IEnumerator EscalarObjeto(Vector3 inicio, Vector3 fin)
    {
        if (EventosPermitidos)
        {
            eventoPanelAlIniciarTrancision.Invoke();
        }
        float tiempo = 0;
        while (tiempo < duracion)
        {
            float t = tiempo / duracion;
            objetoAEscalar.localScale = Vector3.Lerp(inicio, fin, t);
            tiempo += Time.deltaTime;
            yield return null;
        }
        objetoAEscalar.localScale = fin;

        if (EventosPermitidos)
        {
            eventoPanelAlAcabarTrancision.Invoke();
        }
    }

   public void SetEventos(bool _state)
    {
        EventosPermitidos = _state;
    }
}
