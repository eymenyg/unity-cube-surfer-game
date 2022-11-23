using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Menu : MonoBehaviour
{
    public void StartMenu()
    {
        SceneChanger.Instance.lastScene = "";
        SceneChanger.Instance.LoadScene("Start_Menu", LoadSceneMode.Single);
    }
}
