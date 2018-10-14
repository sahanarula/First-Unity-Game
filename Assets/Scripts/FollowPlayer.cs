using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public Transform PlayerPosition;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		transform.position = PlayerPosition.position + offset;
	}
}
