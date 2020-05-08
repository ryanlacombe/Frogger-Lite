using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveBehavior : MonoBehaviour
{
    /**
     * A Reference for the speed of the obstacle
     **/
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

            if (transform.position.x >= 8)
            {
                Destroy(gameObject);
            }
        }
    }
}
