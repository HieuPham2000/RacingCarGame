using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour
{
    public int ModeSelection;
    public GameObject RaceModeUI;
    public GameObject ScoreModeUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreGroupObjects;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if(ModeSelection == 1)
        {
            RaceModeUI.SetActive(false);
            ScoreModeUI.SetActive(true);
            AICar.SetActive(false);
            ScoreGroupObjects.SetActive(true);
        }
    }

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
    }
}
