using UnityEngine;

public class InteractText : MonoBehaviour
{
    public GameObject interactText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          interactText.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.SetActive(false);
        }
    }
}
