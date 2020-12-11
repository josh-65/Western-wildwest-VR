using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuChange : MonoBehaviour
{
    public GameObject main;
    public GameObject settings;
    public GameObject character;

    void Start() 
    {
        menuMain();
    }

    public void menuMain()
    {
        main.SetActive(true);
        settings.SetActive(false);
        character.SetActive(false);
    }

    public void menuSettings()
    {
        main.SetActive(false);
        settings.SetActive(true);
        character.SetActive(false);
    }

    public void menuCharacter()
    {
        main.SetActive(false);
        settings.SetActive(false);
        character.SetActive(true);
    }
}
