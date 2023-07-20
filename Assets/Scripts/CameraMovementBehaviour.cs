using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehaviour : MonoBehaviour
{
    /// <summary>
    /// A reference to the player's transform is stored to keep track
    /// of its position.
    /// </summary>
    public Transform PlayerTransform;

    /// <summary>
    /// This will store how far the camera needs to be from the player.
    /// </summary>
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        //Find the distance the camera should be from the player.
        offset = PlayerTransform.position.z - transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Find the specific z position of the camera using the offset.
        float newZPosition = PlayerTransform.position.z - offset;    

        //Change the camera position to the new position that is directly behind the player.
        transform.position = new Vector3(transform.position.x, transform.position.y, newZPosition);
    }
}
