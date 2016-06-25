using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
	public float fireDelay = 0.50f;
	public GameObject bulletPrefab;
	int bulletLayer;
	float cooldownTimer = 0;


	Transform player;
	// Update is called once per frame
	void Start(){
		bulletLayer = gameObject.layer;
	}
	void Update () {

		if (player == null) {
			GameObject go = GameObject.FindWithTag ("Player");

			if (go != null) {
				player = go.transform;
			}
		}
		cooldownTimer -= Time.deltaTime;

		if (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position,player.position)<4 ) 
		{
			cooldownTimer = fireDelay;
			Vector3 offset = transform.rotation*new Vector3(0,0.5f,0);
			GameObject bulletGO = (GameObject)Instantiate (bulletPrefab,transform.position+offset,transform.rotation);
			bulletGO.layer = bulletLayer;
		}
	}
}
