using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Button>().onClick.AddListener(quit);
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void quit()
    {
        Application.Quit();
    }
}
