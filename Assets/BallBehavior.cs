using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
    [SerializeField]
    LevelManager levelManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        levelManager.LoadLevel("Start Menu");
    }
}
