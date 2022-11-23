using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerCubeManager : MonoBehaviour
{
    private float stepLength = 0.15f;
    private float playerStepLength = 0.2f;

    public List<CubeBehaviour> cubeList = new List<CubeBehaviour>();

    private void Awake()
    {
        Singleton();
    }

    
    #region Singleton

    public static PlayerCubeManager Instance;

    private void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    #endregion

private void RelocatePlayer()
    {
        int cubeIndex = cubeList.Count - 1;
        var playerTransform = PlayerBehaviour.Instance.transform;
        var yValue = cubeIndex * stepLength * playerStepLength;
        var playerTarget = new Vector3(0f, yValue, 0f);

        playerTransform.DOLocalMove(playerTarget, 0.05f);
    }
    public void GetCube(CubeBehaviour cubeBehaviour)
    {
        cubeList.Add(cubeBehaviour);
        cubeBehaviour.isStacked = true;

        cubeBehaviour.transform.parent = transform;

        ReorderCubes();

        RelocatePlayer();
    }

    public void DropCube(CubeBehaviour cubeBehaviour)
    {
        cubeBehaviour.transform.parent = null;
        cubeBehaviour.isStacked = false;

        cubeList.Remove(cubeBehaviour);


        if (cubeList.Count < 1)
        {
            FinishController.onFail();

            return;
        }

        RelocatePlayer();

    }

    private void ReorderCubes()
    {
        int index = cubeList.Count - 1;

        foreach(var cube in cubeList)
        {
            Vector3 target = new Vector3(0f, index * stepLength, 0f);
            cube.transform.DOLocalMove(target, 0.05f);
            index--;
        }
    }
}
