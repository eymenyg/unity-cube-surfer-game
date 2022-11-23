using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
    public void NextLevel()
    {
        if (SceneChanger.Instance.lastScene == "Level_1")
        {
            SceneChanger.Instance.lastScene = "Level_2";
            SceneChanger.Instance.LoadScene("Level_2", LoadSceneMode.Single);
        }

        else if (SceneChanger.Instance.lastScene == "Level_2")
        {
            SceneChanger.Instance.lastScene = "Level_3";
            SceneChanger.Instance.LoadScene("Level_3", LoadSceneMode.Single);
        }

        else if (SceneChanger.Instance.lastScene == "Level_3")
        {
            SceneChanger.Instance.LoadScene("Level_3", LoadSceneMode.Single);
        }
    }
}
