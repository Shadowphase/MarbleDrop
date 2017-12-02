using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private float timer = 0;
    [SerializeField]
    private float launchForce = 50;

    GameObject ball;

    // Use this for initialization
    void Start () {
        ball = (GameObject)Resources.Load("Prefab/ball");
    }
	
	// Update is called once per frame
	void Update () {
        if(timer > 0){
            timer -= Time.deltaTime;
        } else {
            if (Input.GetKeyDown(KeyCode.Space)) {
                spawnBall();
                timer = 0.2f;
            }
        }
	}

    void spawnBall()
    {
        GameObject ballInst = Instantiate(ball, transform.position, Quaternion.identity);
        ballInst.GetComponent<Rigidbody2D>().AddForce(Vector2.up * (launchForce + Random.value * 50));
    }
}
