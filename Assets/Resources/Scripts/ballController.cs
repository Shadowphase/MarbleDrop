using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    [SerializeField]
    int lifespan = 15;

    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
