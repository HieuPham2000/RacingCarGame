using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;

    void Start()
    {
        TotalCash = PlayerPrefs.GetInt(Constant.PlayerPrefsKey.SavedCash);
    }

    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<Text>().text = "Cash: $" + CashValue;
    }
}
