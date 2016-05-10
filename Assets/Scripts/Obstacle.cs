using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-4, 0);
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
