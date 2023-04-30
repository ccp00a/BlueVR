using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchActive : MonoBehaviour
{
    private bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SwitchIt()
    {
        // Debug.Log("Enter Switch it");
        if (this.gameObject.active)
        {
            //Debug.Log("Deactivate");
            this.gameObject.SetActive(false);
        }
        else
        {
            //Debug.Log("Activate");
            this.gameObject.SetActive(true);
        }
    }
}
