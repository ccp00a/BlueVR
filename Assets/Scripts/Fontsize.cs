using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Fontsize : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        btn.onClick.AddListener(OnBtnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBtnClick()
    {
        List<GameObject> gameObjects = new List<GameObject>();

        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
        {
            if (!EditorUtility.IsPersistent(go.transform.root.gameObject) && !(go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave))
            {
                if (go.tag == "NewGoodLabel")
                {
                    go.SetActive(true);
                }
                else if(go.tag == "OldGoodLabel")
                {
                    go.SetActive(false);
                }
            }
        }

    }

}