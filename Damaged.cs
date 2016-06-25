using UnityEngine;
using System.Collections;

public class Damaged : MonoBehaviour {

	public int health = 1;
	public float invulnPeriod = 0;
	float invulnTime = 0;
	int correctLayer;
	SpriteRenderer spriteRend;

	void Start(){
		
		correctLayer = gameObject.layer;
		spriteRend = GetComponent<SpriteRenderer>();
		if (spriteRend == null) {
			spriteRend = transform.GetComponentInChildren<SpriteRenderer> ();
		}
	}
	//Check if there is collision between bullet and player/enemy
	public void OnTriggerEnter2D () {


			health--;

		invulnTime = invulnPeriod;
			gameObject.layer = 10;

	}
	public void Update(){
		if (invulnTime > 0) {
			invulnTime -= Time.deltaTime;

			if (invulnTime <= 0) {
				gameObject.layer = correctLayer;
				if (spriteRend != null) {
					spriteRend.enabled = true;
				}
			} 
			else {

				if (spriteRend != null) {
					spriteRend.enabled = !spriteRend.enabled;
				}
			}
		}
		if (health <= 0) {
			
			Die ();

		}
	}
	//Death
	 void Die(){
		Destroy (gameObject);
	}

}
