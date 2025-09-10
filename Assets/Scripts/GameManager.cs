using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	public bool gameStarted;
	int score=0;
	public Text scoreText;
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
	public void IncreaseScore()
	{
		score++;
		scoreText.text=score.ToString();
	}
}
