using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_control : MonoBehaviour {
    public GameObject yellow_text;
    public GameObject green_text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        yellow_text.GetComponent<Text>().text = (Globals.play1_defeat).ToString();
        green_text.GetComponent<Text>().text = (Globals.play2_defeat).ToString();
    }
}
