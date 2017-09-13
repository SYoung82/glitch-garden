using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Attacker : MonoBehaviour {

	private float walkSpeed;
	private GameObject currentTarget;
	private Animator anim;
	// Use this for initialization
	void Start () {
		Rigidbody2D thisRigidbody = gameObject.AddComponent<Rigidbody2D>();
		thisRigidbody.isKinematic = true;
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
		if(!currentTarget) {
			anim.SetBool("isAttacking", false);
		}
	}

	void OnTriggerEnter2D() {
		Debug.Log(name + " trigger enter");
	}

	public void SetSpeed(float speed) {
		walkSpeed = speed;
	}

	// Called from the animator at the time of attack
	public void StrikeCurrentTarget(float damage) {
		if(currentTarget) {	
			Health health = currentTarget.GetComponent<Health>();
			if(health) {
				health.DealDamage(damage);
			}
		}
	}

	public void Attack(GameObject obj) {
		currentTarget = obj;
	}
}
