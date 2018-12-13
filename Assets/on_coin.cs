using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_coin : MonoBehaviour {
    public AudioSource temp;
    public Globals global;
	// Use this for initialization
	void Start () {
        temp = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("hi");
            temp.Play();
        }
        Globals.coin_collected += 1;
        StartCoroutine(destruction());
    }

    IEnumerator destruction()
    {
        if (temp.isPlaying)
            yield return new WaitForSeconds(0.15f);
        Destroy(this.gameObject);
    }

}
