using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int RaceMode; // 0 = Race, 1 = Score, 2 = Time
    public GameObject TrackSelect;

    public void ScoreMode()
    {
        RaceMode = (int)Enumeration.RaceMode.Score;
        TrackSelect.SetActive(true);
    }

    public void TimeMode()
    {
        RaceMode = (int)Enumeration.RaceMode.Time;
        TrackSelect.SetActive(true);
    }

    public void TheRaceMode()
    {
        RaceMode = (int)Enumeration.RaceMode.Race;
        TrackSelect.SetActive(true);
    }
}
