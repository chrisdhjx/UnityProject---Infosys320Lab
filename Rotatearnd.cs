using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatearnd : MonoBehaviour {

    public Vector3 spinSpeed = Vector3.zero;

	// Use this for initialization
	void Start () {
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, Vector3.up, 1.0f);
	}
}
