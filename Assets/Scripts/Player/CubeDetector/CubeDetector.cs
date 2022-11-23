using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var cubeBehaviour = collision.gameObject.GetComponent<CubeBehaviour>();

        if (collision.gameObject.CompareTag("Cube"))
        {

            if (!cubeBehaviour.isStacked)
            {
                PlayerCubeManager.Instance.GetCube(cubeBehaviour);
            }
        }


    }
}
