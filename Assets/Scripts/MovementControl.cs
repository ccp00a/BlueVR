using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    private Animator anim;
    private float timeCounter;

    public float startWalkTime;
    public float waitTime; 
    public float walkSpeed;

    Vector3 movetowards;

    void Start()
    {
        anim = GetComponent<Animator>();
        timeCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timeCounter += Time.deltaTime;
        



        if (timeCounter > startWalkTime && timeCounter <= waitTime)
        {
            anim.SetBool("idleToWalk", true);
            movetowards = Vector3.MoveTowards(transform.position, new Vector3(-13, 0, 17), Time.deltaTime * walkSpeed);
            transform.position = movetowards;

        }

        if (transform.position.x + 13.5 > 0)
            anim.SetBool("walkToWait", true);

        if (timeCounter > waitTime)
        {
            anim.SetBool("waitToCross", true);
            movetowards = Vector3.MoveTowards(transform.position, new Vector3(18, 0, 17), Time.deltaTime * walkSpeed);
            transform.position = movetowards;
        }

        if (transform.position.x - 16.5 > 0)
            anim.SetBool("crossToStop", true);
    }
}
