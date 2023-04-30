using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightorWrong : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ta1, ta2, ta3, ta4, ta5;
    void Start()
    {
        ta1.SetActive(false);
        ta2.SetActive(false);
        ta3.SetActive(false);
        ta4.SetActive(false);
        ta5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (TriggerScore.A1score == 0 && TriggerScore.Alice_score == 0)
            {
                ta1.SetActive(true);
            }
            if (TriggerScore.D1score == 0 && TriggerScore.Daniel_score == 0)
            {
                ta2.SetActive(true);
            }
            if (TriggerScore.E1score  == 0 && TriggerScore.Echo_score  == 0)
            {
                ta3.SetActive(true);
            }
            if (TriggerScore.Y1score  == 0 && TriggerScore.Yihao_score == 0)
            {
                ta4.SetActive(true);
            }
            if (TriggerScore.M1score == 0 && TriggerScore.Me_score == 0)
            {
                ta5.SetActive(true);
            }
        }
    }
}
