using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketGuideTrigger : MonoBehaviour
{
    public GameObject bucketToDestory;
    public string Tag;
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            bucketToDestory.SetActive(false);
        }
    }
}
