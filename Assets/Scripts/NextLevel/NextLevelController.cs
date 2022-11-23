using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelController : MonoBehaviour
{

    private void Start()
    {
        var lastScene = SceneChanger.Instance.lastScene;

        if (SceneChanger.Instance.success)
        {
            GameObject.Find("Failed_Banner").SetActive(false);
            if (lastScene == "Level_3")
                GameObject.Find("Next_Level_Button").SetActive(false);
        }
        else
        {
            GameObject.Find("Well_Done_Banner").SetActive(false);
            GameObject.Find("Next_Level_Button").SetActive(false);
        }
    }
}
