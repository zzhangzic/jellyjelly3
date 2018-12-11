using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class on_break : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnJointBreak2D(Joint2D joint)
    {
        Debug.Log("joint break");
        SceneManager.LoadScene("main");
    }
}
