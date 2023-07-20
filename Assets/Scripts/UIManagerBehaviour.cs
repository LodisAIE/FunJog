using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIManagerBehaviour : MonoBehaviour
{
    public CanvasGroup EndScreen;
    public Image BackgroundImage;
    public TextMeshProUGUI WinTextBox;
    public TextMeshProUGUI LoseTextBox;
    public float FadeInSpeed;

    bool fadeInEnabled;
   
    public void FadeInLevelCompleteScreen()
    {
        BackgroundImage.color = Color.white;
        WinTextBox.gameObject.SetActive(true);

        fadeInEnabled = true;
    }

    public void FadeInLevelFailScreen()
    {
        BackgroundImage.color = Color.black;
        LoseTextBox.gameObject.SetActive(true);

        fadeInEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeInEnabled == false || EndScreen.alpha >= 1)
        {
            return;
        }

        EndScreen.alpha = EndScreen.alpha + Time.deltaTime * FadeInSpeed;
    }
}
