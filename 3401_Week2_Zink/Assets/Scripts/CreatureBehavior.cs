using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureBehavior : MonoBehaviour
{
    #region Variables

    [Header ("References")] //property drawers
    public NavMeshAgent agent;
    public Transform destination;

    [Header("Properties")]
    [Range (0,100)]
    public float currentSatiation = 100;
    public float HungerSpeed = 3;
    public float FeedRate = 3;
    public float normalMoveSpeed = 3.5f;
    public float hungryMoveSpeed = 7;

    #endregion

	
	void Update ()
    {
        SetAgentSpeed();

        //if hungry, then MOVE
        if(currentSatiation < 50 && currentSatiation > 0)
        {
            agent.SetDestination(destination.position);
        }


        //take a bite if close and not full
        //agent.transform.position or just transform.position
        if ((Vector3.Distance(transform.position, destination.position) <= 2) && currentSatiation < 100)
        {
            currentSatiation += Time.deltaTime * FeedRate; //lose hunger
        }
        else
        {
            if (currentSatiation > 0) //not dead
                currentSatiation -= Time.deltaTime * HungerSpeed; //-1 per sec, get hungry
        }
	}


    void SetAgentSpeed()
    {
        //HungerSpeed and death
        if (currentSatiation <= 0)
        {
            agent.speed = 0;
            Debug.Log("You have died.");
        }

        agent.speed = currentSatiation < 20 ? hungryMoveSpeed : normalMoveSpeed;

        /* line above definition:
        if (currentSatiation < 20)
        {
            agent.speed = hungryMoveSpeed; //speed up
        }
        else
        {
            agent.speed = normalMoveSpeed; //normal speed
        }
         */
    }


}
