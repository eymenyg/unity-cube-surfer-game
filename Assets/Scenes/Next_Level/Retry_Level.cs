using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry_Level : MonoBehaviour
{
    public void RetryLevel()
    {
        SceneChanger.Instance.LoadScene(SceneChanger.Instance.lastScene, LoadSceneMode.Single);
    }
}
