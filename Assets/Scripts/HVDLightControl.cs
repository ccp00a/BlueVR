using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HVDLightControl : MonoBehaviour
{

    //private float gtime = 10;   //ÂÌµÆÁÁ9s£¬»ÆµÆÁÁ2s£¬ºìµÆÁÁ9s£¬»ÆµÆÁÁ2s
    //private float ytime = 2;
    //private float rtime = 10;
    private float alltime = 22; //Ò»ÂÖ×Ü¹²22s

    public float greenStartTime = 0;
    public float greenDuration = 28;
    public float yellowDuration = 2;
    public float redDuration = 60;


    void Start()
    {
        //ÈËÐÐµÆ1Îª×óÓÒ£¬2ÎªÇ°ºó
        //ºìÂÌµÆ1¡¢3Îª×óÓÒ£¬2¡¢4ÎªÇ°ºó


        Invoke("TurnYellow", greenStartTime + greenDuration);   //³õÊ¼ÎªÂÌµÆ£¬29ÃëºóÂÌµÆÃð£¬ÁÁ»ÆµÆ

        Invoke("TurnRed", greenStartTime + greenDuration + yellowDuration);   //»ÆµÆ2Ãëºó±äºì

        Invoke("TurnGreen", greenStartTime + greenDuration + yellowDuration + redDuration);   //ºìµÆÁÁ60Ãëºó±äÂÌ

    }

    void Update()
    {

    }

    void TurnGreen()
    {
        GameObject fbgreenlight1 = transform.Find("HVD_2/Green1").gameObject;
        GameObject fbgreenlight2 = transform.Find("HVD_4/Green1").gameObject;
        GameObject fbgreenlight3 = transform.Find("HVD_2/Green2").gameObject;
        GameObject fbgreenlight4 = transform.Find("HVD_4/Green2").gameObject;
        fbgreenlight1.SetActive(true);
        fbgreenlight2.SetActive(true);
        fbgreenlight3.SetActive(true);
        fbgreenlight4.SetActive(true);
        GameObject fbredlight1 = transform.Find("HVD_2/Red1").gameObject;
        GameObject fbredlight2 = transform.Find("HVD_4/Red1").gameObject;
        GameObject fbredlight3 = transform.Find("HVD_2/Red2").gameObject;
        GameObject fbredlight4 = transform.Find("HVD_4/Red2").gameObject;
        fbredlight1.SetActive(false);
        fbredlight2.SetActive(false);
        fbredlight3.SetActive(false);
        fbredlight4.SetActive(false);

        GameObject lrgreenlight1 = transform.Find("HVD_1/Green1").gameObject;
        GameObject lrgreenlight2 = transform.Find("HVD_3/Green1").gameObject;
        GameObject lrgreenlight3 = transform.Find("HVD_1/Green2").gameObject;
        GameObject lrgreenlight4 = transform.Find("HVD_3/Green2").gameObject;
        lrgreenlight1.SetActive(false);
        lrgreenlight2.SetActive(false);
        lrgreenlight3.SetActive(false);
        lrgreenlight4.SetActive(false);
        GameObject lrredlight1 = transform.Find("HVD_1/Red1").gameObject;
        GameObject lrredlight2 = transform.Find("HVD_3/Red1").gameObject;
        GameObject lrredlight3 = transform.Find("HVD_1/Red2").gameObject;
        GameObject lrredlight4 = transform.Find("HVD_3/Red2").gameObject;
        lrredlight1.SetActive(true);
        lrredlight2.SetActive(true);
        lrredlight3.SetActive(true);
        lrredlight4.SetActive(true);

        GameObject lryellowlight1 = transform.Find("HVD_1/Yellow1").gameObject;
        GameObject lryellowlight2 = transform.Find("HVD_3/Yellow1").gameObject;
        GameObject lryellowlight3 = transform.Find("HVD_1/Yellow2").gameObject;
        GameObject lryellowlight4 = transform.Find("HVD_3/Yellow2").gameObject;
        lryellowlight1.SetActive(false);
        lryellowlight2.SetActive(false);
        lryellowlight3.SetActive(false);
        lryellowlight4.SetActive(false);
        GameObject fbyellowlight1 = transform.Find("HVD_2/Yellow1").gameObject;
        GameObject fbyellowlight2 = transform.Find("HVD_4/Yellow1").gameObject;
        GameObject fbyellowlight3 = transform.Find("HVD_2/Yellow2").gameObject;
        GameObject fbyellowlight4 = transform.Find("HVD_4/Yellow2").gameObject;
        fbyellowlight1.SetActive(false);
        fbyellowlight2.SetActive(false);
        fbyellowlight3.SetActive(false);
        fbyellowlight4.SetActive(false);

    }

    void TurnYellow()
    {
        GameObject fbgreenlight1 = transform.Find("HVD_2/Green1").gameObject;
        GameObject fbgreenlight2 = transform.Find("HVD_4/Green1").gameObject;
        GameObject fbgreenlight3 = transform.Find("HVD_2/Green2").gameObject;
        GameObject fbgreenlight4 = transform.Find("HVD_4/Green2").gameObject;
        fbgreenlight1.SetActive(false);
        fbgreenlight2.SetActive(false);
        fbgreenlight3.SetActive(false);
        fbgreenlight4.SetActive(false);
        GameObject fbredlight1 = transform.Find("HVD_2/Red1").gameObject;
        GameObject fbredlight2 = transform.Find("HVD_4/Red1").gameObject;
        GameObject fbredlight3 = transform.Find("HVD_2/Red2").gameObject;
        GameObject fbredlight4 = transform.Find("HVD_4/Red2").gameObject;
        fbredlight1.SetActive(false);
        fbredlight2.SetActive(false);
        fbredlight3.SetActive(false);
        fbredlight4.SetActive(false);

        GameObject lrgreenlight1 = transform.Find("HVD_1/Green1").gameObject;
        GameObject lrgreenlight2 = transform.Find("HVD_3/Green1").gameObject;
        GameObject lrgreenlight3 = transform.Find("HVD_1/Green2").gameObject;
        GameObject lrgreenlight4 = transform.Find("HVD_3/Green2").gameObject;
        lrgreenlight1.SetActive(false);
        lrgreenlight2.SetActive(false);
        lrgreenlight3.SetActive(false);
        lrgreenlight4.SetActive(false);
        GameObject lrredlight1 = transform.Find("HVD_1/Red1").gameObject;
        GameObject lrredlight2 = transform.Find("HVD_3/Red1").gameObject;
        GameObject lrredlight3 = transform.Find("HVD_1/Red2").gameObject;
        GameObject lrredlight4 = transform.Find("HVD_3/Red2").gameObject;
        lrredlight1.SetActive(false);
        lrredlight2.SetActive(false);
        lrredlight3.SetActive(false);
        lrredlight4.SetActive(false);

        GameObject lryellowlight1 = transform.Find("HVD_1/Yellow1").gameObject;
        GameObject lryellowlight2 = transform.Find("HVD_3/Yellow1").gameObject;
        GameObject lryellowlight3 = transform.Find("HVD_1/Yellow2").gameObject;
        GameObject lryellowlight4 = transform.Find("HVD_3/Yellow2").gameObject;
        lryellowlight1.SetActive(true);
        lryellowlight2.SetActive(true);
        lryellowlight3.SetActive(true);
        lryellowlight4.SetActive(true);
        GameObject fbyellowlight1 = transform.Find("HVD_2/Yellow1").gameObject;
        GameObject fbyellowlight2 = transform.Find("HVD_4/Yellow1").gameObject;
        GameObject fbyellowlight3 = transform.Find("HVD_2/Yellow2").gameObject;
        GameObject fbyellowlight4 = transform.Find("HVD_4/Yellow2").gameObject;
        fbyellowlight1.SetActive(true);
        fbyellowlight2.SetActive(true);
        fbyellowlight3.SetActive(true);
        fbyellowlight4.SetActive(true);
    }

    void TurnRed()
    {
        GameObject fbgreenlight1 = transform.Find("HVD_2/Green1").gameObject;
        GameObject fbgreenlight2 = transform.Find("HVD_4/Green1").gameObject;
        GameObject fbgreenlight3 = transform.Find("HVD_2/Green2").gameObject;
        GameObject fbgreenlight4 = transform.Find("HVD_4/Green2").gameObject;
        fbgreenlight1.SetActive(false);
        fbgreenlight2.SetActive(false);
        fbgreenlight3.SetActive(false);
        fbgreenlight4.SetActive(false);
        GameObject fbredlight1 = transform.Find("HVD_2/Red1").gameObject;
        GameObject fbredlight2 = transform.Find("HVD_4/Red1").gameObject;
        GameObject fbredlight3 = transform.Find("HVD_2/Red2").gameObject;
        GameObject fbredlight4 = transform.Find("HVD_4/Red2").gameObject;
        fbredlight1.SetActive(true);
        fbredlight2.SetActive(true);
        fbredlight3.SetActive(true);
        fbredlight4.SetActive(true);

        GameObject lrgreenlight1 = transform.Find("HVD_1/Green1").gameObject;
        GameObject lrgreenlight2 = transform.Find("HVD_3/Green1").gameObject;
        GameObject lrgreenlight3 = transform.Find("HVD_1/Green2").gameObject;
        GameObject lrgreenlight4 = transform.Find("HVD_3/Green2").gameObject;
        lrgreenlight1.SetActive(true);
        lrgreenlight2.SetActive(true);
        lrgreenlight3.SetActive(true);
        lrgreenlight4.SetActive(true);
        GameObject lrredlight1 = transform.Find("HVD_1/Red1").gameObject;
        GameObject lrredlight2 = transform.Find("HVD_3/Red1").gameObject;
        GameObject lrredlight3 = transform.Find("HVD_1/Red2").gameObject;
        GameObject lrredlight4 = transform.Find("HVD_3/Red2").gameObject;
        lrredlight1.SetActive(false);
        lrredlight2.SetActive(false);
        lrredlight3.SetActive(false);
        lrredlight4.SetActive(false);

        GameObject lryellowlight1 = transform.Find("HVD_1/Yellow1").gameObject;
        GameObject lryellowlight2 = transform.Find("HVD_3/Yellow1").gameObject;
        GameObject lryellowlight3 = transform.Find("HVD_1/Yellow2").gameObject;
        GameObject lryellowlight4 = transform.Find("HVD_3/Yellow2").gameObject;
        lryellowlight1.SetActive(false);
        lryellowlight2.SetActive(false);
        lryellowlight3.SetActive(false);
        lryellowlight4.SetActive(false);
        GameObject fbyellowlight1 = transform.Find("HVD_2/Yellow1").gameObject;
        GameObject fbyellowlight2 = transform.Find("HVD_4/Yellow1").gameObject;
        GameObject fbyellowlight3 = transform.Find("HVD_2/Yellow2").gameObject;
        GameObject fbyellowlight4 = transform.Find("HVD_4/Yellow2").gameObject;
        fbyellowlight1.SetActive(false);
        fbyellowlight2.SetActive(false);
        fbyellowlight3.SetActive(false);
        fbyellowlight4.SetActive(false);
    }

}
