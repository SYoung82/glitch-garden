using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

	private float walkSpeed;
	private GameObject currentTarget;

	// Use this for initialization
	void Start () {
		Rigidbody2D thisRigidbody = gameObject.AddComponent<Rigidbody2D>();
		thisRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D() {
		Debug.Log(name + " trigger enter");
	}

	public void SetSpeed(float speed) {
		walkSpeed = speed;
	}

	// Called from the animator at the time of attack
	public void StrikeCurrentTarget(float damage) {
		Debug.Log(name + " caused damage: " + damage);
	}

	public void Attack(GameObject obj) {
		currentTarget = obj;
	}
}
