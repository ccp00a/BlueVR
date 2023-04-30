using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTellme : MonoBehaviour
{
    public TMP_Text countingStar;
    private string textDefault, textCheckout;
    private bool isDefault, isCheckout;
    // Start is called before the first frame update
    void Start()
    {
        textCheckout = "Alice: " + TriggerScore.Alice_score
        + " Daniel: " + TriggerScore.Daniel_score
        + " Echo: " + TriggerScore.Echo_score
        + " YihaoL " + TriggerScore.Yihao_score
        + " Me: " + TriggerScore.Me_score;
        textDefault = "Checkout Here!!!";
        isDefault = true;
        isCheckout = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        textCheckout = "Alice: " + TriggerScore.Alice_score
        + " Daniel: " + TriggerScore.Daniel_score
        + " Echo: " + TriggerScore.Echo_score
        + " YihaoL " + TriggerScore.Yihao_score
        + " Me: " + TriggerScore.Me_score;

        if (isDefault)
        {
            countingStar.text = textDefault;
        }

        else if (isCheckout)
        {
            countingStar.text = textCheckout;
        }

    }

    public void DefaultText()
    {
        isDefault = true;
        isCheckout = false;
    }

    public void CheckOutText()
    {
        isDefault = false;
        isCheckout = true;
    }
}
