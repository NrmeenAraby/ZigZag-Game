using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	public bool gameStarted;
	int score=0;
	public Text scoreText;
	public Text highScoreText;


	public void Awake()
	{
        highScoreText.text = "Best: " + GetHighScore().ToString();

    }
    public void StartGame()
	{
		gameStarted = true;
		FindObjectOfType<Road>().StartBuilding();
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
		if (score > GetHighScore())
		{
			PlayerPrefs.SetInt("HighScore", score);
			highScoreText.text="Best: "+score.ToString();
		}
	}
	public int GetHighScore()
	{
		int h = PlayerPrefs.GetInt("HighScore");
		return h;
	}
}
