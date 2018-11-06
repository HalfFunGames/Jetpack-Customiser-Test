using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	
	Rigidbody2D body;

    public GameObject gameOverScreen;
	
	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		if (gameOver) {
			
			if (Input.GetMouseButtonDown(0)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
			return;
		}
		if (Input.GetMouseButton(0)) {
			body.AddForce(new Vector2(0, 50), ForceMode2D.Force);
		} else if (Input.GetMouseButtonUp(0)) {
			body.velocity *= 0.25f;
		}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            gameOver = true;
            body.isKinematic = true;
        }
    }
}
