using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsToggle : MonoBehaviour
{
     private Canvas CanvasObject; 
     private Canvas CanvasObject1;
 
     void Start () 
     {
         CanvasObject = GameObject.Find("Main Menu").GetComponent<Canvas>();
         CanvasObject1 = GameObject.Find("Settings Menu").GetComponent<Canvas>();

         CanvasObject.GetComponent<Canvas> ().enabled = true;
         CanvasObject1.GetComponent<Canvas> ().enabled = false;
     }
 
     public void ToggleCanvas ()
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