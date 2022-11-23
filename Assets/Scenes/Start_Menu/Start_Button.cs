using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public void StartGame()
    {
        SceneChanger.Instance.lastScene = "Level_1";
        SceneChanger.Instance.LoadScene("Level_1", LoadSceneMode.Single);
    }
}
