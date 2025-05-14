using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelController : MonoBehaviour
{

    public void CambiarScene(string nombreScene)
    {
        SceneManager.LoadSceneAsync(nombreScene);
    }
}
