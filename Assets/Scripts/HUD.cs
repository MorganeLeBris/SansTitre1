using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour {

	float playerScore = 0;
	public Image im;
	public Text finalScore;
	public Text score;
	private bool stop;
	private GUIContent test;
	public Button retry;
	public Text retryText;
    public Button back;
    public Text backText;
    public Text gameOverText;

    // Use this for initialization
    void Start () {
		stop = false;
		im.enabled = false;
		retry.image.enabled = false;
		retryText.enabled = false;
        back.image.enabled = false;
        backText.enabled = false;
        gameOverText.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (!stop) {
			playerScore += (Time.deltaTime / 3);
			score.text = "Score: " + (int)(playerScore * 100);
		}
	}

	public void IncreaseScore(int amount){
		playerScore += amount;
	}

	public void Retry(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


    public void GameOver(){
		stop = true;
		retry.image.enabled = true;
		retryText.enabled = true;
        back.image.enabled = true;
        backText.enabled = true;
        gameOverText.enabled = true;
        score.text = "";
		im.enabled = true;
		FindObjectOfType< UnitySampleAssets._2D.Platformer2DUserControl>().Stop();
		finalScore.text = "Final Score : " + (int)(playerScore*100);
		foreach (SpawnGround other in FindObjectsOfType<SpawnGround>()) {
			Destroy (other.gameObject);
		}
		Destroy (FindObjectOfType<SpawnObstacles>().gameObject);
	
	}
}

