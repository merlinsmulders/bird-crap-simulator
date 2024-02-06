using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject menu;
    public bool isMenuOpen;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isMenuOpen = !isMenuOpen;
            menu.SetActive(isMenuOpen);
        }
    }
}
