using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_Story : MonoBehaviour
{
    public TMP_Text narrator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        narrator.text = "The Story begins here";
    }
}
