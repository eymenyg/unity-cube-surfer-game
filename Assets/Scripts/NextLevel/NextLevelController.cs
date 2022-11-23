using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{

    private void Start()
    {
        var lastScene = SceneChanger.Instance.lastScene;
        

        if (lastScene == "Level_3")
        {
            GameObject.Find("Next_Level_Button").SetActive(false);
        }

        if (!SceneChanger.Instance.success)
        {
            GameObject.Find("Next_Level_Button").SetActive(false);
            GameObject.Find("Well_Done_Banner").SetActive(false);
        }

        else
        {
            GameObject.Find("Failed_Banner").SetActive(false);
        }
    }
}
