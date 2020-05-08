using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

    /**
    * A MonoBehavior that spawns obstacles in a certain order
    **/
public class SpawnBehavior : MonoBehaviour
{
    /**
     * References to the obstacles to be spawned
     **/
    public GameObject obstacle1;
    public GameObject obstacle2;

    /**
     * A Reference to keep track of how many obstacles there are
     **/
    public int obstacleMaxAmount = 8;
    public int obstacleCurrentAmount = 0;

    /**
     * References for spacing obstacles.
     **/
    public int spawnRate;
    private int timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            timer--;            
            if (obstacleCurrentAmount < obstacleMaxAmount && timer <= 0)
            {
                if (obstacleCurrentAmount % 2 == 1)
                {
                    GameObject tmp2 = Instantiate(obstacle2);

                    tmp2.transform.position = transform.position;
                    
                }
                else
                {
                    GameObject tmp1 = Instantiate(obstacle1);

                    tmp1.transform.position = transform.position;
                    
                }
                obstacleCurrentAmount++;
                timer = spawnRate;               
            }         
        }
    }   
}
