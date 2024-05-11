using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void StartNewScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}