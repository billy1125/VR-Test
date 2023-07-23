using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour
{
    public TextMeshProUGUI TitleText;

    public void ButtonClick()
    {
        Debug.Log("It is pressed.");
        if (TitleText != null)
            TitleText.SetText("It is pressed.");
    }
}
