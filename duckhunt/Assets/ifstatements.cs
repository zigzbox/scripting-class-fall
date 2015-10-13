using UnityEngine;
using System.Collections;

public class ifstatements : MonoBehaviour {
    public float cupLimit = 50.0f;
    public float cupOverLimit = 45.0f;
    public float cupUnderLimit = 15.0f;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
           VolumeTest();
        cupLimit -= Time.deltaTime * 5f;
    }

    void VolumeTest()
    {
        if(cupLimit > cupOverLimit)
        {
            print("cup is over flowing");
        }
        else if(cupLimit < cupUnderLimit)
        {
            print("There's nothing in the cup");
        }
        else
        {
            print("Yep!");
        }
    }
}
