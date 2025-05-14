using UnityEngine;
using UnityEngine.UI;

public class BajarEnergia : MonoBehaviour
{
    public Image barraEnergia;  // Asigna la imagen tipo "Filled" desde el Inspector
    public float velocidadReduccion = 0.1f; // Velocidad de reducción por segundo

    void Update()
    {
        if (barraEnergia != null && barraEnergia.fillAmount > 0)
        {
            barraEnergia.fillAmount -= velocidadReduccion * Time.deltaTime;
        }
    }
}
