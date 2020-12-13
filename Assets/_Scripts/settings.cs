using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[System.Serializable]
public class settings : MonoBehaviour {
    
    public AudioMixer mixer;

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
}