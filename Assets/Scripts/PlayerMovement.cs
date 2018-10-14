using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody RB;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// Update is called once per frame
	void FixedUpdate () {
		RB.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d")) {
			RB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) {
			RB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (RB.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
