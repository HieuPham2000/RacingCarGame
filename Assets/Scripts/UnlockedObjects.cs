using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour
{
    public int blackSelect;
    public GameObject fakeBlack;
    void Start()
    {
        blackSelect = PlayerPrefs.GetInt(Constant.PlayerPrefsKey.BlackBought);
        if(blackSelect == 100)
        {
            fakeBlack.SetActive(false);
        } else
        {
            fakeBlack.SetActive(true);
        }
    }
}
