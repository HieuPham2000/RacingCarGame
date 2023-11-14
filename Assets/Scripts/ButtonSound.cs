using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void PlayHoverSound()
    {
        mySound.PlayOneShot(hoverSound);
    }

    public void PlayClickSound()
    {
        mySound.PlayOneShot(clickSound);
    }
}
