using UnityEngine;
using System.Collections;


public class PauseGame1 : MonoBehaviour {
	public Transform canvas;
	// public Transform Player;


	// Update is called once per frame

	public void Pause(){
		//In case the canvas is false, activate it if Esc is pressed
		if (canvas.gameObject.activeInHierarchy == false) {
			canvas.gameObject.SetActive (true);
			//Stop everything
			Time.timeScale = 0;

		} 
		else 
		{
			//Deactivate canvas if it was activated 
			canvas.gameObject.SetActive(false);
			//Put game back
			Time.timeScale = 1;
		
		}
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause ();
	
		}
}
	public void Restart(){
		Time.timeScale = 1;
		Application.LoadLevel ("Level1");
	}
	public void Quit(){
		Time.timeScale = 1;
		Application.LoadLevel ("MainMenu");
	}

}
