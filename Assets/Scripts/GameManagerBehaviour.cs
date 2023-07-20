using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehaviour : MonoBehaviour
{
    public WinBoxBehaviour WinBox;
    public PlayerMovementBehaviour PlayerMovement;

    public UIManagerBehaviour UIManager;

    // Update is called once per frame
    void Update()
    {
        if (WinBox.HasWon)
        {
            UIManager.FadeInLevelCompleteScreen();
            PlayerMovement.CanMove = false;
        }
        else if (PlayerMovement.gameObject.activeInHierarchy == false)
        {
            UIManager.FadeInLevelFailScreen();
        }
    }
}
