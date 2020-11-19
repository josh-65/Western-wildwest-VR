using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using SaveSystem;

[System.Serializable]
public class settings : MonoBehaviour {
    
    public AudioMixer mixer;
    public Dropdown resDropdown;
    Resolution[] ress;

    void Start() {
        //Gets and Displays resolutions
        ress = Screen.resolutions;
        resDropdown.ClearOptions();
        List<string> allowRes = new List<string>();

        int currentResIndex = 0;
        for (int i = 0; i < ress.Length; i++) {
            string option = ress[i].width+"x"+ress[i].height;
            allowRes.Add(option);

            if (ress[i].width == Screen.currentResolution.width && ress[i].height == Screen.currentResolution.height) {
                currentResIndex = i;
            }
        }
        
        resDropdown.AddOptions(allowRes);
        resDropdown.value = currentResIndex;
        resDropdown.RefreshShownValue();
    }

    //General--------------------------------
    public void fullscreen(bool isFull) {
        Screen.fullScreen = isFull;
    }
    
    //Sets resolution
    public void setRes(int currentResIndex) {
        Resolution res = ress[currentResIndex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

    //Sets graphics
    public void quality (int index) {
        QualitySettings.SetQualityLevel(index);
    }

    //Sets volume
    public void SetMusic(float Music) {
        mixer.SetFloat("Music", Music);
    }
    
    public void SetSFX(float SFX) {
        mixer.SetFloat("SFX", SFX);
    }
}