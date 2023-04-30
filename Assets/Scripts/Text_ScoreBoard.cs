using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_ScoreBoard : MonoBehaviour
{
    public TMP_Text countingStar;
    private string textDefault, textCheckout;
    private bool isDefault, isCheckout;
    // Start is called before the first frame update
    void Start()
    {
        textCheckout = "Place your bucket on the table if you want to check out.";
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
        //textcheckout = "alice: " + triggerscore.alice_score
        //+ " daniel: " + triggerscore.daniel_score
        //+ " echo: " + triggerscore.echo_score
        //+ " yihaol " + triggerscore.yihao_score
        //+ " me: " + triggerscore.me_score;

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
