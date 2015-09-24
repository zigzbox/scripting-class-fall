using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    int numEnemies = 5;
	// Use this for initialization
	void Start () {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number:" + i);
        }
        	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
