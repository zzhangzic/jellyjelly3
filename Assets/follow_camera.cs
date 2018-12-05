using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour {
    public GameObject targeta;
    public GameObject targetb;
    private Vector3 offset;
    Vector3 target;
    // Use this for initialization
    void Start () {
        target = (targeta.transform.position + targetb.transform.position) / 2;
        offset = transform.position - target;
    }
	
	// Update is called once per frame
	void Update () {
        target = (targeta.transform.position + targetb.transform.position) / 2;
        transform.position = target + offset;
    }
}
