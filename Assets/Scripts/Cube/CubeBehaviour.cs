using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public bool isStacked = false;

    private RaycastHit hit;

    private void FixedUpdate()
    {
        if (!isStacked)
            return;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 0.1f))
        {
            if (hit.transform.gameObject.CompareTag("Obstacle"))
            {
                hit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
                PlayerCubeManager.Instance.DropCube(this);
            }
        }
    }

}
