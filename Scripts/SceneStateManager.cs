using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateManager : MonoBehaviour
{
    public static SceneStateManager instance;

    public enum SceneType
    {
        Title,
        Main,
        Result
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(SceneType LoadSceneName)
    {
        SceneManager.LoadScene(LoadSceneName.ToString());
    }

}
