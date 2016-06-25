using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public float fireDelay = 0.25f;
	public GameObject bulletPrefab;
	public Vector3 bulletOffset = new Vector3(0,0.5f,0);
	int bulletLayer;
	float cooldownTimer = 0;

	void Start(){
		bulletLayer = gameObject.layer;
	}
	// Update is called once per frame

	void Update () {

		cooldownTimer -= Time.deltaTime;
		if (Input.GetButton("Fire1") && cooldownTimer <= 0) {
			//SHOOT
			cooldownTimer = fireDelay; 
			Vector3 offset = transform.rotation*bulletOffset;
			GameObject bulletGo = (GameObject)Instantiate (bulletPrefab,transform.position+offset,transform.rotation);
			bulletGo.layer = bulletLayer;

		}
	}
}
