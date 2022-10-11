using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    void Update()
    {
        if(LapsDone == 1)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        var sceneBuilderIndex = SceneManager.GetActiveScene().buildIndex;
        if (collider.gameObject.tag == "Player" || collider.gameObject.tag == "Dreamcar")
        {
            LapsDone++;

            RawTime = PlayerPrefs.GetFloat("RawTime", LapTimeManager.RawTime);
            if (LapTimeManager.RawTime <= RawTime)
            {

                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
                }

                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount.ToString("F0");

                PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
                PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
                PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
                PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);
            }

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RawTime = 0;

            LapCounter.GetComponent<Text>().text = "" + LapsDone;

            HalfLapTrig.SetActive(true);

            // TODO: Thử để đoạn code check ở đây
            if (LapsDone == 1)
            {
                RaceFinish.SetActive(true);
            }

            LapCompleteTrig.SetActive(false);
        }
        
    }
}
