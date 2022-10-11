using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCar : MonoBehaviour
{
    public static int CarType; // 1 = red, 2 = blue, 3 = black
    public GameObject ModeSelect;
    public GameObject CarSelect;

    public void RedCar()
    {
        CarType = (int)Enumeration.CarBodyColor.RedBody;
        ModeSelect.SetActive(true);
    }

    public void BlueCar()
    {
        CarType = (int)Enumeration.CarBodyColor.BlueBody;
        ModeSelect.SetActive(true);
    }

    public void BlackCar()
    {
        CarType = (int)Enumeration.CarBodyColor.BlackBody;
        ModeSelect.SetActive(true);
    }
}
