using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans_GetDark : MonoBehaviour
{
    public Animator darkCurtain;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            darkCurtain.SetTrigger("EndScene");
        }
    }
}
