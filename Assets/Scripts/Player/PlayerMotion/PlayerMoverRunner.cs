using UnityEngine;

public class PlayerMoverRunner : MonoBehaviour
{
    public float Velocity;

    private void FixedUpdate()
    {
        transform.position += new Vector3(0F, 0F, 1F) * Time.deltaTime * Velocity;

        if (transform.position.x > 0.15F)
        {
            transform.position = new Vector3(0.15f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -0.17F)
        {
            transform.position = new Vector3(-0.17f, transform.position.y, transform.position.z);
        }
    }
}