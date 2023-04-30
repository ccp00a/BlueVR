using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTrigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text_ScoreBoard targetText;
    void Start()
    {
        targetText.DefaultText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Enter Story1");
            targetText.CheckOutText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetText.DefaultText();
            Debug.Log("Exit Story1");
        }
    }
}
