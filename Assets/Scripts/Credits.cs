﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public AudioSource sound;

    // Use this for initialization
    void Start()
    {
        sound.Play();
    }


    // Update is called once per frame
    void Update () {
		
	}

    public void ClickBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
