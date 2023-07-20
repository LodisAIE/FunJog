using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    PlayerMovementBehaviour movementBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        movementBehaviour = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            movementBehaviour.Jump();
        }


        //If the player pressed the A key...
        if (Input.GetKey(KeyCode.A))
        {
            //...move to the left.
            movementBehaviour.MoveDirection = Vector3.left;
        }
        //Or if the player pressed the D key...
        else if (Input.GetKey(KeyCode.D))
        {
            //...move to the right.
            movementBehaviour.MoveDirection = Vector3.right;
        }
        //Otherwise if the player isn't pressing anything...
        else
        {
            //...don't move.
            movementBehaviour.MoveDirection = Vector3.zero;
        }
    }
}
