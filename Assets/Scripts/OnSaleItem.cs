using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class OnSaleItem : MonoBehaviour
{
    public Button btn;
    public Color txtcolor, bgcolor;
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
                if (go.tag == "OnSaleText")
                {
                    go.GetComponent<Graphic>().color = txtcolor;
                }
                else if (go.tag == "OnSaleBg")
                {
                    go.GetComponent<Graphic>().color = bgcolor;
                }
            }
        }

    }
}
