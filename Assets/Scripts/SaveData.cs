using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData : MonoBehaviour
{
    //public TriggerScore scoreTaker;
    public string filename;
    private string textCheckout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            WriteString();
        }
    }
    public void WriteString()
    {
        textCheckout = "alice: " + TriggerScore.Alice_score + " and " + TriggerScore.A1score
        + " daniel: " + TriggerScore.Daniel_score + " and " + TriggerScore.D1score
        + " echo: " + TriggerScore.Echo_score + " and " + TriggerScore.E1score
        + " yihaol " + TriggerScore.Yihao_score + " and " + TriggerScore.Y1score
        + " me: " + TriggerScore.Me_score + " and " + TriggerScore.M1score
        + "Wrong: " + TriggerScore.Wrong_score + " and " + TriggerScore.Wrong_score;
        string path = "Assets/Resources/" + filename + ".txt";
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(textCheckout);
        writer.Close();
        StreamReader reader = new StreamReader(path);
        //Print the text from the file
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}
