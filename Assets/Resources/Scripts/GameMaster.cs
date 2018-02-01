using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    [SerializeField]
    private int MAX_PINS = 30;
    GameObject pin;

    // Use this for initialization
    void Start () {
        pin = (GameObject)Resources.Load("Prefab/pin");
        int count = 0;
        for (int i = 0; i < MAX_PINS; ++i)
        {
            if (i % 5 == 0)
            {
                ++count;
            }
            float x = -1.8f + (count % 2) * 0.2f + 0.4f * (i % 5);
            float y = 1.2f - 0.4f * count;
            Vector3 pos = new Vector3(x, y, 0);
            Instantiate(pin, pos, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
