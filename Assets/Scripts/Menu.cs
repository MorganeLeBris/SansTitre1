using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public AudioSource sound;
    public Image tuto;
    public Button tutoBT;


    // Use this for initialization
    void Start () {
        sound.Play();
        tuto.enabled = false;
        tutoBT.enabled = false;
        tutoBT.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickPlayTuto()
    {

        SceneManager.LoadScene("Main");
    }

    public void ClickPlay()
    {
        tutoBT.enabled = true;
        tuto.enabled = true;
        tutoBT.gameObject.SetActive(true);

    }

    public void ClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ClickQuit()
    {
        Application.Quit();
    }
}
