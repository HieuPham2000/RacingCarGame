using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    public GameObject largeButton;
    public GameObject menuButton;
    public GameObject cashDisplay;

    public void clickToBegin()
    {
        largeButton.SetActive(false);
        menuButton.SetActive(true);
        cashDisplay.SetActive(true);
    }

}
