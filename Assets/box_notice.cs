using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_notice : MonoBehaviour {
    public GameObject[] active_text;
    public GameObject[] disable_text;
    public GameObject outline;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            foreach(GameObject temp in disable_text)
            {
                temp.SetActive(false);
            }
        }
        foreach (GameObject temp in active_text)
        {
            temp.SetActive(true);
        }
        outline.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (GameObject temp in disable_text)
        {
            temp.SetActive(true);
        }
        foreach (GameObject temp in active_text)
        {
            temp.SetActive(false);
        }
        outline.SetActive(false);
    }
}
