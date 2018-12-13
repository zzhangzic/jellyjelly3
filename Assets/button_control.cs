using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(reload);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void reload()
    {
        SceneManager.LoadScene("main");
    }
}
