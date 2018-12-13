using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scecret_trigger : MonoBehaviour {
    private bool play;
	// Use this for initialization
	void Start () {
        play = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (play == false)
            {
                this.GetComponent<AudioSource>().Play();
                play = true;
            }
            Debug.Log(collision.gameObject.tag);
            Transform parent = this.gameObject.transform.parent;
            foreach (Transform child in parent)
            {
                if (child.gameObject.GetComponent<SpriteRenderer>())
                {
                    child.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
                }
            }
        }
    }
}
