using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_coin : MonoBehaviour {
    public AudioSource temp;
    public Globals global;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            temp.Play();
        }
        Globals.coin_collected += 1;
        Destroy(this.gameObject);
    }
}
