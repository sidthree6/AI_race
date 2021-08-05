using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float turnSpeed = 0.05f;
    private float moveSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerTurn();

        GetPlayerForwardMovement();
    }

    private void GetPlayerTurn()
    {
        float currentRotation = transform.localEulerAngles.y;

        if (Input.GetKey(KeyCode.A))
        {
            currentRotation += TurnBasedOnInput("left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            currentRotation += TurnBasedOnInput("right");
        }

        transform.localEulerAngles = new Vector3(0, currentRotation, 0);
    }

    private float TurnBasedOnInput(string direction)
    {
        if (direction == "left")
        {
            return turnSpeed * -1;
        }
        if (direction == "right")
        {
            return turnSpeed;
        }
        else
        {
            return 1.0f;
        }
    }

    private void GetPlayerForwardMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 1 * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * moveSpeed;
        }
    }

}
