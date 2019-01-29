using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMotor : MonoBehaviour
{
    #region Variables

    [Header("References")] //property drawers
    public NavMeshAgent agent2;
    public Transform destination2;

    [Header("Properties")]
    [Range(0, 100)]
    public float currentSatiation2 = 100;
    public float HungerSpeed2 = 3;
    public float FeedRate2 = 3;
    public float normalMoveSpeed2 = 3.5f;
    public float hungryMoveSpeed2 = 7;
    public bool SlowDown;

    #endregion


    void Update()
    {
        SetAgentSpeed2();

        //if hungry or SlowDown, then MOVE
        if (currentSatiation2 < 50 && currentSatiation2 > 0 || (SlowDown == true && normalMoveSpeed2 > 0))
        {
            agent2.SetDestination(destination2.position);
        }

        //take a bite if close and not full
        //agent2.transform.position or just transform.position
        if ((Vector3.Distance(transform.position, destination2.position) <= 2) && currentSatiation2 < 100)
        {
            currentSatiation2 += Time.deltaTime * FeedRate2; //lose hunger
        }
        else
        {
            if (currentSatiation2 > 0) //not dead
                currentSatiation2 -= Time.deltaTime * HungerSpeed2; //-1 per sec, get hungry
        }
    }


    void SetAgentSpeed2()
    {
        //HungerSpeed and death
        if (currentSatiation2 <= 0)
        {
            agent2.speed = 0;
            Debug.Log("You have died.");
        }

        if(SlowDown == true) //slow down until 0
        {
            if(normalMoveSpeed2 >= 0)
            {
                normalMoveSpeed2 -= Time.deltaTime * .1f;
                agent2.speed = normalMoveSpeed2;
                //hungryMoveSpeed2 -= .01f;
            }
            else{
                hungryMoveSpeed2 = 0f;
                agent2.speed = 0;
                Debug.Log("slowed to 0");
            }
        }

        if(SlowDown == false)
            agent2.speed = currentSatiation2 < 20 ? hungryMoveSpeed2 : normalMoveSpeed2;

        /* line above definition:
        if (currentSatiation < 20)
        {
            agent2.speed = hungryMoveSpeed2; //speed up
        }
        else
        {
            agent2.speed = normalMoveSpeed2; //normal speed
        }
         */
    }

}
