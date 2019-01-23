using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;     // A reference to our PlayerMovement script

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
        
    }
}
