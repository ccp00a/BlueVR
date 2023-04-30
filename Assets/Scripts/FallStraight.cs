using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallStraight : MonoBehaviour
{
    public Quaternion origin;
    // Start is called before the first frame update
    void Start()
    {
        origin = GetComponent<Transform>().rotation;
        // Debug.Log("Origin is: " + origin);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Reset()
    {
        GetComponent<Transform>().rotation = origin;
        // Debug.Log("I reset it!");
        // Debug.Log(GetComponent<Transform>().rotation);
    }
}
