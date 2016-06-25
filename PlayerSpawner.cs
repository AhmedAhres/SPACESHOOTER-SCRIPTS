using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public GameObject player;
	GameObject playerInstance;
	//int score = 0;
	public int numLives = 4;
	float respawnTimer = 1;
	public Damaged dm;


	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn(){
		numLives--;
		respawnTimer = 1;

		playerInstance =  (GameObject) Instantiate (player,transform.position, Quaternion.identity);
		playerInstance.name = "PlayerShip";
	}


	// Update is called once per frame
	void Update () {
		
		if (playerInstance == null && numLives > 0) {


			respawnTimer -= Time.deltaTime;
			if (respawnTimer <= 0) {
				Spawn ();
			}

		}
			
	}
	void OnGUI(){
		if (numLives > 0 || playerInstance != null) {
			GUI.Label (new Rect (10, 10, 100, 50), "Lives left: " + numLives);


		} else  {
			//If you lose all your lives, load the "TryAgain" scene
			Application.LoadLevel ("TryAgain");
		}

	}
}
