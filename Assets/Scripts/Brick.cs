using UnityEngine;
using System.Collections;
////////////////////////////////////////////////////////////////
//   Class:   Brick
//   Purpose:    
//   
//   
//   
//   Notes:
//   Contributors: RSF
////////////////////////////////////////////////////////////////

public class Brick : MonoBehaviour {

    public Sprite[] hitSprites;
    public int maxHits;


    private int timesHit;

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        timesHit++;
        if(timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        //TODO MAKES THE SPRITES AND ADD
        //int spriteIndex = timesHit - 1;
        //this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }
}
