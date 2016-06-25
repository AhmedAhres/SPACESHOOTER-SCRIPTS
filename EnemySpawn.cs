using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy;

	float spawnDis = 13f;
	float enemyRate = 5;
	float nextEnemy = 1;


	
	// Update is called once per frame
	void Update () {
		nextEnemy -= Time.deltaTime;

		if (nextEnemy <= 0) {
			nextEnemy = enemyRate;
			enemyRate *= 0.99f;
			if (enemyRate < 2)
				enemyRate = 2;


			//Keep limit
			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDis;

			Instantiate (enemy, transform.position + offset, Quaternion.identity);
		}
	}
}
