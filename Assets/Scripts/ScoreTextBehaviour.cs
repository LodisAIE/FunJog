using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTextBehaviour : MonoBehaviour
{
    public PlayerMovementBehaviour Player;
    TextMeshProUGUI ScoreTextBox;

    // Start is called before the first frame update
    void Start()
    {
        ScoreTextBox = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTextBox.text = "Score:" + Player.Score;
    }
}
