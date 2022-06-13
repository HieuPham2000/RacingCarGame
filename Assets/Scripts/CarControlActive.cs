using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject TheCar;
    public GameObject Dreamcar01;
    // Start is called before the first frame update
    void Start()
    {
        //Behaviour CarController = (Behaviour)TheCar.GetComponent("CarController");
        //CarController.enabled = true;

        //Behaviour CarAIControl01 = (Behaviour)Dreamcar01.GetComponent("CarAIControl");
        //CarAIControl01.enabled = true;

        TheCar.GetComponent<CarController>().enabled = true;
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
    }
}
