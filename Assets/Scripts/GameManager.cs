using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	public bool gameStarted;

	public void StartGame()
	{
		gameStarted = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.V)) { 
		   StartGame();
		}
	}
	public void EndGame()
	{
		SceneManager.LoadScene(0);
	}
}
