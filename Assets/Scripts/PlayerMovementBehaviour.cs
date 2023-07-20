using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    /// <summary>
    /// How fast the player can move forward on the track.
    /// </summary>
    public int ForwardSpeed = 10;
    /// <summary>
    /// How fast the player can dodge side to side.
    /// </summary>
    public int HorizontalSpeed = 5;

    public int MinimumXPosition;

    public int MaximumXPosition;

    public float JumpPower;

    Rigidbody _rigidBody;

    /// <summary>
    /// The direction the player wants to move in currently.
    /// </summary>
    public Vector3 MoveDirection;

    public GroundColliderBehaviour GroundCollider;

    public float AirSpeedScale;

    public bool CanMove;

    public int Score;

    public GameObject Explosion;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        if (GroundCollider.IsGrounded)
        {
            _rigidBody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            Instantiate(Explosion, transform.position, Quaternion.identity);
        }
        else if (other.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            Score = Score + 1;
        }
    }

    private void FixedUpdate()
    {
        if (CanMove == false)
        {
            return;
        }
        //Find how fast we should go forward.
        Vector3 forwardVelocity = Vector3.forward * ForwardSpeed * Time.deltaTime;
        //Find how the direction and how fast to go side ways.
        Vector3 horizontalVelocity = MoveDirection * HorizontalSpeed * Time.deltaTime;

        if (GroundCollider.IsGrounded == false)
        {
            horizontalVelocity = horizontalVelocity / AirSpeedScale;
        }


        //Find a new position.
        Vector3 newPosition = transform.position + forwardVelocity + horizontalVelocity;

        newPosition.x = Mathf.Clamp(newPosition.x, MinimumXPosition, MaximumXPosition);

        //Set the new position to be the current position.
        transform.position = newPosition;
    }
}
