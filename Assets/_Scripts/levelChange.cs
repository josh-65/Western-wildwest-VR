using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    public int creditLength;

    void Update() {
        Scene S = SceneManager.GetActiveScene();
        if (S.name == "M - Credits") {
            StartCoroutine(reset());

            IEnumerator reset() {
                yield return new WaitForSeconds(creditLength);
                SceneManager.LoadScene(0);
            }
        }
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("quit");
    }

    public void loadCredits() {
        SceneManager.LoadScene(1);
    }
}