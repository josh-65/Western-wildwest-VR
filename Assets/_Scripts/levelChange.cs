using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    public Animator transition;
    public float Time = 0f;
    public string transname;

    void Update() {
        Scene S = SceneManager.GetActiveScene();
        if (S.name == "M - Credits") {
            StartCoroutine(reset());

            IEnumerator reset() {
                yield return new WaitForSeconds(78);
                SceneManager.LoadScene("M - Main");
            }
        }
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("quit");
    }

    public void loadNextLevel() {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator loadLevel(int levelIndex) {
        transition.SetTrigger(transname);
        yield return new WaitForSeconds(Time);
        SceneManager.LoadScene(levelIndex);
    }
}