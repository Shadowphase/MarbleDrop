using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

    private CanvasGroup fadeGroup;
    private float loadTime;
    private float minimumLogoTime = 3.0f;

	// Use this for initialization
	void Start () {
        fadeGroup = FindObjectOfType<CanvasGroup>();
        Debug.Log(fadeGroup);
        fadeGroup.alpha = 1;

        //preload the game. load stuff from outside
        if (Time.time < minimumLogoTime) {
            loadTime = minimumLogoTime;
        }
        else {
            loadTime = Time.time;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time < minimumLogoTime) {
            fadeGroup.alpha = 1 - Time.time;
        }
        if(Time.time > minimumLogoTime && loadTime != 0)
        {
            fadeGroup.alpha = Time.time - minimumLogoTime;
            if(fadeGroup.alpha >= 1) {
                SceneManager.LoadScene("MainMenu");
            }
        }
	}
}
