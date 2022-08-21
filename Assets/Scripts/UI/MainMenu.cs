using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject logo;
    public TextMeshProUGUI text;

    public void HoverText()
    {
        text.fontSize = 75;
        logo.SetActive(true);
    }

    public void ExitHoverText()
    {
        text.fontSize = 64;
        logo.SetActive(false);
    }

}
