using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
	
	private Rigidbody rb;
	public float tumble;
	public float speed;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.angularVelocity = Random.insideUnitSphere*tumble;	
		rb.velocity = transform.forward * speed;

	}
	
}
