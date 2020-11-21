using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using SaveSystem;

[System.Serializable]
public class settings : MonoBehaviour {
    
    public AudioMixer mixer;
    private Canvas CanvasObject; 
    private Canvas CanvasObject1;
    private Canvas CanvasObject2;

    public void Start() {
        CanvasObject = GameObject.Find("Main").GetComponent<Canvas>();
        CanvasObject1 = GameObject.Find("Settings").GetComponent<Canvas>();
        CanvasObject1 = GameObject.Find("Character select").GetComponent<Canvas>();
        CanvasObject.GetComponent<Canvas>().enabled = true;
        CanvasObject1.GetComponent<Canvas>().enabled = false;
        CanvasObject1.GetComponent<Canvas>().enabled = false;
    }

    //Sets graphics
    public void quality (int index) {
        QualitySettings.SetQualityLevel(index);
    }

    //Sets volume
    public void SetMaster(float master) {
        mixer.SetFloat("master", master);
    }
    public void SetMusic(float music) {
        mixer.SetFloat("music", music);
    }
    public void SetSFX(float sfx) {
        mixer.SetFloat("sfx", sfx);
    }
    public void SetDialog(float dialog) {
        mixer.SetFloat("dialog", dialog);
    }
    public void SetVoiceChat(float voiceChat) {
        mixer.SetFloat("voiceChat", voiceChat);
    }
 
    public void toggleCanvas()
    {
        if (CanvasObject.enabled == true) {
            CanvasObject.GetComponent<Canvas> ().enabled = false;
            CanvasObject1.GetComponent<Canvas> ().enabled = true;
        } else {
            CanvasObject.GetComponent<Canvas> ().enabled = true;
            CanvasObject1.GetComponent<Canvas> ().enabled = false;
        }
    }
}