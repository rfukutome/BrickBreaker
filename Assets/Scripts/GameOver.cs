using UnityEngine;
using System.Collections;
////////////////////////////////////////////////////////////////
//   Class:   GameOver
//   Purpose:    
//   
//   
//   
//   Notes:
//   Contributors: RSF
////////////////////////////////////////////////////////////////

public class GameOver : MonoBehaviour {

    private LevelManager levelManager;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball") {
            levelManager.LoadLevel("Start Menu");
        }
    }
}
