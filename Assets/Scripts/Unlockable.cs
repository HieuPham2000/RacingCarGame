using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour
{
    public GameObject fakeBlackButton;
    public int cashValue;

    void Update()
    {
        cashValue = GlobalCash.TotalCash;

        if(cashValue >= 100)
        {
            fakeBlackButton.GetComponent<Button>().interactable = true;
        } else
        {
            fakeBlackButton.GetComponent<Button>().interactable = false;
        }


    }

    public void BlackUnlock()
    {
        fakeBlackButton.SetActive(false);
        cashValue -= 100;
        GlobalCash.TotalCash -= 100;
        PlayerPrefs.SetInt(Constant.PlayerPrefsKey.SavedCash, GlobalCash.TotalCash);
        PlayerPrefs.SetInt(Constant.PlayerPrefsKey.BlackBought, 100);
    }
}
