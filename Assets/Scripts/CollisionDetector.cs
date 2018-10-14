using UnityEngine;

public class CollisionDetector : MonoBehaviour {
	public PlayerMovement movement;

	void OnCollisionEnter (Collision collisionInfo) {
		Debug.Log(collisionInfo.collider.tag);
		if (collisionInfo.collider.tag == "Obstacle") {
			Debug.Log("Collision Happened");
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
