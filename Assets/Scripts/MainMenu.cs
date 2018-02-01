using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.33f;

 	// Use this for initialization
	void Start () {
        fadeGroup = FindObjectOfType<CanvasGroup>();
        fadeGroup.alpha = 1;		
	}
	
	// Update is called once per frame
	void Update () {
        fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
	}

    //Buttons
    public void OnPlayClick()
    {
        Debug.Log("Play clicked");
    }

    public void OnStoreClick()
    {
        Debug.Log("Store Clicked");
    }
}
