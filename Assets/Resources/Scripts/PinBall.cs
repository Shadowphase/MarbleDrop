using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBall : MonoBehaviour {
	float height;
	// Use this for initialization
	void Start () {
		height = Camera.main.orthographicSize * 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		//float scale = 2f / (gameObject.transform.position.y + height/2);
		float scale = 0.3f/((gameObject.transform.position.y / height) + 1);
		gameObject.transform.localScale = new Vector3(scale, scale, scale);
	}
}
