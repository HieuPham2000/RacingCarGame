using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    // 1 = red, 2 = blue
    public GameObject RedBody;
    public GameObject BlueBody;
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if(CarImport == 1)
        {
            RedBody.SetActive(true);
        } else if (CarImport == 2)
        {
            BlueBody.SetActive(true);
        }
    }

}
