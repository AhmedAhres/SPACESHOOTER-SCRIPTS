using UnityEngine;
using System.Collections;

public class FacePlayer : MonoBehaviour {
	public float rotSpeed = 90f;

	Transform player;


	// Update is called once per frame
	void Update () {
		//If there is no player
		if (player == null) {
			GameObject go = GameObject.Find("PlayerShip");

			if (go != null) {
				player = go.transform;
			}
		}


		if (player == null) 
			return; //Try again next frame


	
		//Look at enemy
		Vector3 dir = player.position - transform.position;
		dir.Normalize ();

		float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

		Quaternion desiredRot = Quaternion.Euler( 0, 0,zAngle );
		transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
		
	
}
}
