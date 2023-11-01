using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlaySecondButtonScript : MonoBehaviour
{
    public Button secondButton;
    public float delayTime = 2f;

    public void whenButtonClicked()
    {
        Invoke("ShowSecondButton", delayTime);
    }

    private void ShowSecondButton()
    {
        secondButton.gameObject.SetActive(true);
    }
}
