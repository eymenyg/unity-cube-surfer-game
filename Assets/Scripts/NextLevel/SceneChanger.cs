using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string lastScene = "";
    public bool success;

    #region Singleton

    public static SceneChanger Instance;

    private void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    #endregion
    private void Awake()
    {
        Singleton();
        DontDestroyOnLoad(this.gameObject);
    }
    public void LoadScene(string newScene, LoadSceneMode mode)
    {
        SceneManager.LoadSceneAsync(newScene, mode);
    }
}
