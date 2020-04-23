using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour {

	Rigidbody2D rb;
	float movement = 0f;
	public float movementSpeed = 10f;

	
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate(){
		rb.velocity = new Vector2(movement, rb.velocity.y);
	}
}
