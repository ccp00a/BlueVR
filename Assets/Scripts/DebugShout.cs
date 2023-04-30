using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugShout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtEnter()
    {
        Debug.Log("Scorer Activate!");
    }

    public void AtExit()
    {
        Debug.Log("Deactivate scorer!");
    }

    public void Respect()
    {
        Debug.Log("Press F to pay respect");
    }
}
