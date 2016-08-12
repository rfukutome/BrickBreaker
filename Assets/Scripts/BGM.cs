using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {
    //Only want one instance of a BGM player, so we create a singleton
    static BGM instance = null;

	// Use this for initialization

    void Awake()
    {
        //Want this object to persist through scenes.
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }
	void Start () {

    }
}
