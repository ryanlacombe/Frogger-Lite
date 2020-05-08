using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBehavior : MonoBehaviour
{
    /**
     * A reference to the CharacterController to move.
     **/
    public CharacterController characterController;

    /**
     * A reference for the number of lives the player has.
     **/
    public int playerLives = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("up"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }

        else if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }

        else if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }

        else if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
    }

    public void ButtonMoveLeft()
    {
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    }

    public void ButtonMoveRight()
    {
        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }

    public void ButtonMoveDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
    }

    public void ButtonMoveUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ObstacleMoveBehavior>())
        {
            Debug.Log("Hello");
            playerLives--;

            if (playerLives <= 0)
            {
                LoadScene(1);
            }

            else
            {
                transform.position = new Vector3(0, -12.3f, 0);
            }
        }
    }

    public void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
