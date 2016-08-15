using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
    private Paddle paddle;


    private bool gameStarted;
    private Vector3 paddleToBallVector;
    private Rigidbody2D rigidBody2D;

    // Use this for initialization
    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        rigidBody2D = this.GetComponent<Rigidbody2D>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            rigidBody2D.velocity =  new Vector2(5f, 10f);
        }
	}
}
