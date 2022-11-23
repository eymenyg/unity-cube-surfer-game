using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    private void OnCollisionEnter()
    {
        PlayerBehaviour.Instance.StopPlayer();
        PlayerBehaviour.Instance.SuccessAnimation();

        SceneChanger.Instance.success = true;
        SceneChanger.Instance.LoadScene("Next_Level", LoadSceneMode.Additive);
    }

    public static void onFail()
    {
        Debug.Log("Game Over");
        PlayerBehaviour.Instance.StopPlayer();
        PlayerBehaviour.Instance.FailAnimation();

        var playerTransform = PlayerBehaviour.Instance.transform;
        Vector3 ground = new Vector3(0f, -0.023f, 0f);
        playerTransform.DOLocalJump(ground, 0.05f, 1, 0.5f);

        SceneChanger.Instance.success = false;
        SceneChanger.Instance.LoadScene("Next_Level", LoadSceneMode.Additive);
    }
}
