using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewMode;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;

    // TODO
    public GameObject LapTimeManager;

    public GameObject RaceModeAnnounce;

    void Start()
    {
        if(RaceModeAnnounce == null)
        {
            RaceModeAnnounce = GameObject.FindGameObjectWithTag("RaceModeAnnounce");
        } 
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player" || collider.gameObject.tag == "Dreamcar")
        {
            if(ModeTime.isTimeMode)
            {
                // time mode
            } else
            {
                this.GetComponent<BoxCollider>().enabled = false;
                MyCar.SetActive(false);
                CompleteTrig.SetActive(false);

                CarController.m_Topspeed = 0.0f;

                MyCar.GetComponent<CarUserControl>().enabled = false;
                MyCar.GetComponent<CarController>().enabled = false;

                MyCar.SetActive(true);

                FinishCam.SetActive(true);
                // PTHIEU 28.6.2022: Tắt âm thanh
                //collider.gameObject.GetComponent<CarAudio>().enabled = false;
                MyCar.GetComponent<CarAudio>().enabled = false;

                LevelMusic.SetActive(false);
                ViewMode.SetActive(false);


                LapTimeManager.SetActive(false);

                if(ModeSelect.RaceMode == 0 && RaceModeAnnounce != null)
                {
                    RaceModeAnnounce.SetActive(true);
                    if (collider.gameObject.tag == "Player")
                    {
                        RaceModeAnnounce.transform.Find("Win").gameObject.SetActive(true);
                        GlobalCash.TotalCash += 100;
                        PlayerPrefs.SetInt(Constant.PlayerPrefsKey.SavedCash, GlobalCash.TotalCash);
                    } else
                    {
                        RaceModeAnnounce.transform.Find("Lose").gameObject.SetActive(true);
                    }
                }

                StartCoroutine(WaitAndBackToMainMenu());
            }
            
        }
    }

    IEnumerator WaitAndBackToMainMenu()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.MainMenu);
    }
}
