using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {
    int cubsInTheSink = 4;
	// Use this for initialization
	void Start () {
        while(cubsInTheSink > 0)
        {
            Debug.Log("I've washed a bear!");
            cubsInTheSink--;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
