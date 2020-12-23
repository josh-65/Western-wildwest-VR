using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class events : MonoBehaviour
{
    private string date;

    void Start() {
        date = DateTime.UtcNow.ToString("dd-MM");
		Debug.Log(date);

        if(date == "31-10") {
            Debug.Log("Halloween");

        }

        if(date == "24-12" || date == "25-12") {
            Debug.Log("christmas");

        }

        if(date == "1-4") {
            Debug.Log("April fools");
            
        }
    }

}
