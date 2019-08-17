using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movementScript;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movementScript.enabled = false;
            Debug.Log("test");
        }
    }
}
