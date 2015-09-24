using UnityEngine;
using System.Collections;

public class ifstate : MonoBehaviour {
    float puppiesAwe = 50.0f;
    float tomanylimitPuppies = 75.0f;
    float notenoughlimitPuppies = 25.0f;
    // Use this for initialization
    void Start() {
        if (Input.GetKeyDown(KeyCode.Space))
            puppiesAwe();
        puppiesAwe -= Time.deltaTime * 5f;

    }
    void yayPuppiesTest()
    {
        else if (puppiesAwe > tomanylimitPuppies)
        {
            print("too many puppies");
        }
        else if (puppiesAwe < notenoughlimitPuppies)
        {
            print("not enough puppies");
        }
        else
        {
            print("yay puppies");
        }
    }
}
