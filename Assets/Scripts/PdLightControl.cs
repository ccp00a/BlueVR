using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PdLightControl : MonoBehaviour
{

    //private float gtime = 10;   //绿灯亮10s，黑1s，红灯亮10s，黑1s
    //private float ytime = 2;     
    //private float rtime = 10;
    //private float alltime = 22; //一轮总共22s

    public float greenStartTime = 0;
    public float greenDuration = 30;
    public float redDuration = 60;

    public bool rightchoice = true;    //记录是否可以过马路

    void Start()
    {
        //人行灯1为左右，2为前后
        //红绿灯1、3为左右，2、4为前后


        Invoke("TurnRed", greenStartTime + greenDuration);    //初始为绿灯，30秒后绿灯灭，亮红灯

        Invoke("TurnGreen", greenStartTime + greenDuration + redDuration);   

        
        //InvokeRepeating("TurnYellow", 20f, alltime);
        //InvokeRepeating("TurnBlack", 22f, alltime);


        //Invoke("TurnRed", greenStartTime + greenDuration + 1);   //黑一秒后红灯亮
        //Invoke("TurnBlack", 32f, alltime);


    }

    void Update()
    {
        
    }

    void TurnGreen()
    {
        GameObject fbgreenlight1 = transform.Find("RX_1/renxinglvse_2").gameObject;
        GameObject fbgreenlight2 = transform.Find("RX_2/renxinglvse_2").gameObject;
        GameObject fbgreenlight3 = transform.Find("RX_3/renxinglvse_2").gameObject;
        GameObject fbgreenlight4 = transform.Find("RX_4/renxinglvse_2").gameObject;
        fbgreenlight1.SetActive(true);
        fbgreenlight2.SetActive(true);
        fbgreenlight3.SetActive(true);
        fbgreenlight4.SetActive(true);
        GameObject fbredlight1 = transform.Find("RX_1/renxinghongse_2").gameObject;
        GameObject fbredlight2 = transform.Find("RX_2/renxinghongse_2").gameObject;
        GameObject fbredlight3 = transform.Find("RX_3/renxinghongse_2").gameObject;
        GameObject fbredlight4 = transform.Find("RX_4/renxinghongse_2").gameObject;
        fbredlight1.SetActive(false);
        fbredlight2.SetActive(false);
        fbredlight3.SetActive(false);
        fbredlight4.SetActive(false);

        GameObject lrgreenlight1 = transform.Find("RX_1/renxinglvse_1").gameObject;
        GameObject lrgreenlight2 = transform.Find("RX_2/renxinglvse_1").gameObject;
        GameObject lrgreenlight3 = transform.Find("RX_3/renxinglvse_1").gameObject;
        GameObject lrgreenlight4 = transform.Find("RX_4/renxinglvse_1").gameObject;
        lrgreenlight1.SetActive(false);
        lrgreenlight2.SetActive(false);
        lrgreenlight3.SetActive(false);
        lrgreenlight4.SetActive(false);
        GameObject lrredlight1 = transform.Find("RX_1/renxinghongse_1").gameObject;
        GameObject lrredlight2 = transform.Find("RX_2/renxinghongse_1").gameObject;
        GameObject lrredlight3 = transform.Find("RX_3/renxinghongse_1").gameObject;
        GameObject lrredlight4 = transform.Find("RX_4/renxinghongse_1").gameObject;
        lrredlight1.SetActive(true);
        lrredlight2.SetActive(true);
        lrredlight3.SetActive(true);
        lrredlight4.SetActive(true);

        rightchoice = true;
    }

    //void TurnYellow()
    //{

    //}

    void TurnRed()
    {
        GameObject fbgreenlight1 = transform.Find("RX_1/renxinglvse_2").gameObject;
        GameObject fbgreenlight2 = transform.Find("RX_2/renxinglvse_2").gameObject;
        GameObject fbgreenlight3 = transform.Find("RX_3/renxinglvse_2").gameObject;
        GameObject fbgreenlight4 = transform.Find("RX_4/renxinglvse_2").gameObject;
        fbgreenlight1.SetActive(false);
        fbgreenlight2.SetActive(false);
        fbgreenlight3.SetActive(false);
        fbgreenlight4.SetActive(false);
        GameObject fbredlight1 = transform.Find("RX_1/renxinghongse_2").gameObject;
        GameObject fbredlight2 = transform.Find("RX_2/renxinghongse_2").gameObject;
        GameObject fbredlight3 = transform.Find("RX_3/renxinghongse_2").gameObject;
        GameObject fbredlight4 = transform.Find("RX_4/renxinghongse_2").gameObject;
        fbredlight1.SetActive(true);
        fbredlight2.SetActive(true);
        fbredlight3.SetActive(true);
        fbredlight4.SetActive(true);

        GameObject lrgreenlight1 = transform.Find("RX_1/renxinglvse_1").gameObject;
        GameObject lrgreenlight2 = transform.Find("RX_2/renxinglvse_1").gameObject;
        GameObject lrgreenlight3 = transform.Find("RX_3/renxinglvse_1").gameObject;
        GameObject lrgreenlight4 = transform.Find("RX_4/renxinglvse_1").gameObject;
        lrgreenlight1.SetActive(true);
        lrgreenlight2.SetActive(true);
        lrgreenlight3.SetActive(true);
        lrgreenlight4.SetActive(true);
        GameObject lrredlight1 = transform.Find("RX_1/renxinghongse_1").gameObject;
        GameObject lrredlight2 = transform.Find("RX_2/renxinghongse_1").gameObject;
        GameObject lrredlight3 = transform.Find("RX_3/renxinghongse_1").gameObject;
        GameObject lrredlight4 = transform.Find("RX_4/renxinghongse_1").gameObject;
        lrredlight1.SetActive(false);
        lrredlight2.SetActive(false);
        lrredlight3.SetActive(false);
        lrredlight4.SetActive(false);

        rightchoice = false;
    }

    void TurnBlack()
    {
        GameObject fbgreenlight1 = transform.Find("RX_1/renxinglvse_2").gameObject;
        GameObject fbgreenlight2 = transform.Find("RX_2/renxinglvse_2").gameObject;
        GameObject fbgreenlight3 = transform.Find("RX_3/renxinglvse_2").gameObject;
        GameObject fbgreenlight4 = transform.Find("RX_4/renxinglvse_2").gameObject;
        fbgreenlight1.SetActive(false);
        fbgreenlight2.SetActive(false);
        fbgreenlight3.SetActive(false);
        fbgreenlight4.SetActive(false);
        GameObject fbredlight1 = transform.Find("RX_1/renxinghongse_2").gameObject;
        GameObject fbredlight2 = transform.Find("RX_2/renxinghongse_2").gameObject;
        GameObject fbredlight3 = transform.Find("RX_3/renxinghongse_2").gameObject;
        GameObject fbredlight4 = transform.Find("RX_4/renxinghongse_2").gameObject;
        fbredlight1.SetActive(false);
        fbredlight2.SetActive(false);
        fbredlight3.SetActive(false);
        fbredlight4.SetActive(false);

        GameObject lrgreenlight1 = transform.Find("RX_1/renxinglvse_1").gameObject;
        GameObject lrgreenlight2 = transform.Find("RX_2/renxinglvse_1").gameObject;
        GameObject lrgreenlight3 = transform.Find("RX_3/renxinglvse_1").gameObject;
        GameObject lrgreenlight4 = transform.Find("RX_4/renxinglvse_1").gameObject;
        lrgreenlight1.SetActive(false);
        lrgreenlight2.SetActive(false);
        lrgreenlight3.SetActive(false);
        lrgreenlight4.SetActive(false);
        GameObject lrredlight1 = transform.Find("RX_1/renxinghongse_1").gameObject;
        GameObject lrredlight2 = transform.Find("RX_2/renxinghongse_1").gameObject;
        GameObject lrredlight3 = transform.Find("RX_3/renxinghongse_1").gameObject;
        GameObject lrredlight4 = transform.Find("RX_4/renxinghongse_1").gameObject;
        lrredlight1.SetActive(false);
        lrredlight2.SetActive(false);
        lrredlight3.SetActive(false);
        lrredlight4.SetActive(false);

        rightchoice = false;
    }

}
