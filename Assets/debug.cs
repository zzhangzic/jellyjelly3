using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour {
    public float temp;
	// Use this for initialization
	void Start () {
        float temp = this.GetComponent<Rope>().BreakForce;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(temp);
        temp = this.GetComponent<Rope>().BreakForce;

    }
}
