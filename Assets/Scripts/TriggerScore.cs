using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScore : MonoBehaviour
{
    private string textcheckout;
    public static bool Score_f1, Score_d1;
    public static int Wrong_score, Fruit1_score, Drink1_score, Alice_score, 
        Daniel_score, Echo_score, Yihao_score, Me_score,
        A1score, D1score, E1score, Y1score, M1score;
    // Start is called before the first frame update
    void Start()
    {
        Score_d1 = false;
        Score_f1 = false;
        Fruit1_score = 0;
        Drink1_score = 0;
        Alice_score = 0;
        Daniel_score = 0;
        Echo_score = 0;
        Yihao_score = 0;
        Me_score = 0;
        Wrong_score = 0;
        A1score = 0;
        D1score = 0;
        E1score = 0;
        Y1score = 0;
        M1score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //textcheckout = "alice: " + TriggerScore.Alice_score
        //+ " daniel: " + TriggerScore.Daniel_score
        //+ " echo: " + TriggerScore.Echo_score
        //+ " yihaol " + TriggerScore.Yihao_score
        //+ " me: " + TriggerScore.Me_score;
        //Debug.Log(textcheckout);
    }

    void FixedUpadte()
    {
        if (Score_f1 && Score_d1 == true) // This means at least one type of object has entered the bucket
        {
            Score_d1 = false;
            Score_f1 = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3) // Layer 3: Grabbable
        {
            string Tag = other.tag;
            switch (Tag)
            {
                case "Alice":
                    Alice_score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Alice +1");
                    break;
                case "Daniel":
                    Daniel_score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Daniel +1");
                    break;
                case "Echo":
                    Echo_score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Echo +1");
                    break;
                case "Yihao":
                    Yihao_score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Yihao +1");
                    break;
                case "Me":
                    Me_score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Me +1");
                    break;
                case "Me2":
                    M1score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Me +1");
                    break;
                case "Daniel2":
                    D1score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Daniel +1");
                    break;
                case "Alice2":
                    A1score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Alice +1");
                    break;
                case "Echo2":
                    E1score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Echo +1");
                    break;
                case "Yihao2":
                    Y1score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Yihao +1");
                    break;
                default:
                    Wrong_score += 1;
                    Destroy(other.gameObject);
                    Debug.Log("Not on List");
                    break;
            }
            //if (other.CompareTag("Fruit1"))
            //{
            //    Debug.Log("Fruit 1 Plus 1");
            //    Destroy(other.gameObject);
            //    Score_f1 = true;
            //    Fruit1_score += 1;
            //}
            //else if (other.CompareTag("Drink1"))
            //{
            //    Debug.Log("Drink 1 Plus 1");
            //    Destroy(other.gameObject);
            //    Score_d1 = true;
            //    Drink1_score += 1;
            //}
        }

    }
}
