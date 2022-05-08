using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public void LoadMainLevel()
    {
        SceneManager.LoadScene(1);
    }
}
