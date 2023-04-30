using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossroadTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CrossroadRay();
    }

    void CrossroadRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Color raycolor = Color.red;

        if(Physics.Raycast(ray, out hit, 10))
        {
            SceneManager.LoadScene("Taks_Oriented");
        }
        Debug.DrawRay(ray.origin, transform.forward * 10, raycolor);
    }
}
