using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    // 1 = red, 2 = blue, 3 = black
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject BlackBody;
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        switch(CarImport)
        {
            case (int)Enumeration.CarBodyColor.RedBody:
                RedBody.SetActive(true);
                break;
            case (int)Enumeration.CarBodyColor.BlueBody:
                BlueBody.SetActive(true);
                break;
            case (int)Enumeration.CarBodyColor.BlackBody:
                BlackBody.SetActive(true);
                break;
            default:
                RedBody.SetActive(true);
                break;
        }
    }

}
