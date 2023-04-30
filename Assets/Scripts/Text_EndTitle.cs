using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_EndTitle : MonoBehaviour
{
    // Start is called before the first frame update
    //public TMP_Text endTitle;
    private bool res1, res2, res3;
    private int alice, daniel, echo, yihao, me, wrong;
    public TMP_Text tit1, tit2, tit3;
    private void Start()
    {
        res1 = false;
        res2 = false;
        res3 = false;
    }
    // Update is called once per frame
    private void Update()
    {
        alice = TriggerScore.Alice_score;
        daniel = TriggerScore.Daniel_score;
        echo = TriggerScore.Echo_score;
        yihao = TriggerScore.Yihao_score;
        me = TriggerScore.Me_score;
        wrong = TriggerScore.Wrong_score;
        if (me > 0 && alice > 0 && daniel >0 && echo > 0 && yihao > 0)
        {
            if (wrong == 0)
            {
                res3 = true;
                res2 = false;
                res1 = false;
            }
            else
            {
                res2 = true;
                res1 = false;
                res3 = false;
            }
        }
        else
        {
            res1 = true;
            res2 = false;
            res3 = false;
        }
        Showshowway();
    }

    public void Showshowway()
    {
        if (res1)
        {
            tit1.gameObject.SetActive(true);
            tit2.gameObject.SetActive(false);
            tit3.gameObject.SetActive(false);
        }
        else if (res2)
        {
            tit2.gameObject.SetActive(true);
            tit1.gameObject.SetActive(false);
            tit3.gameObject.SetActive(false);
        }
        else if (res3)
        {
            tit3.gameObject.SetActive(true);
            tit1.gameObject.SetActive(false);
            tit2.gameObject.SetActive(false);
        }
    }
}

