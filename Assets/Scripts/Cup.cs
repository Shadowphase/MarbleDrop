using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cup : MonoBehaviour {

    public UnityEvent OtherFunctions;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "ball(Clone)") {
            Destroy(other.gameObject);
            CallOtherFunctions();
        }
    }

    void CallOtherFunctions()
    {
        OtherFunctions.Invoke();
    }
}
