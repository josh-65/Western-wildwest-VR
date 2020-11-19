using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    public AudioClip hoverFx;

    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx);
    }

}
