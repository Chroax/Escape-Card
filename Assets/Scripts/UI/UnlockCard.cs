using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCard : MonoBehaviour
{

    public GameObject Panel;

    public void OpenUnlockCardPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
