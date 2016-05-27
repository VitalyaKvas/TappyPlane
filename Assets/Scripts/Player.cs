using UnityEngine;
using System.Linq;

public class Player : MonoBehaviour
{
	public Vector2 jumpForce = new Vector2(0, 300);

	void Jump()
	{
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(jumpForce);
	}

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
        // SceneManager.LoadScene("Scenes/Level", LoadSceneMode.Single)
    }

    void Update()
    {
        if (Input.GetKeyUp("space"))
            Jump();

        // Die by being off screen
        Vector2 screenPosition = Camera.allCameras.First().WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }
}
