using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBoxBehaviour : MonoBehaviour
{
    public bool HasWon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HasWon = true;
        }
    }
}
