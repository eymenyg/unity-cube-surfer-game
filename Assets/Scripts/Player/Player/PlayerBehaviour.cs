using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private Animator playerAnimator;

    public PlayerMoverRunner playerMoverRunner;

    private void Awake()
    {
        Singleton();
    }

    #region Singleton

    public static PlayerBehaviour Instance;

    private void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    #endregion

    public void SuccessAnimation()
    {
        playerAnimator.SetTrigger("Success");
    }

    public void FailAnimation()
    {
        playerAnimator.SetTrigger("Fail");
    }
    public void StopPlayer()
    {
        playerMoverRunner.Velocity = 0;
    }
}
