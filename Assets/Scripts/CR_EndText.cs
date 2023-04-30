using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CR_EndText : MonoBehaviour
{
    public PdLightControl pedestrianLight;
    public TMP_Text Result1, Result2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pedestrianLight.rightchoice)
            {
                Result2.gameObject.SetActive(true);
                Result1.gameObject.SetActive(false);
            }
            else
            {
                Result2.gameObject.SetActive(false);
                Result1.gameObject.SetActive(true);
            }
        }

    }
}
