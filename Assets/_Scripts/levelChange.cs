using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    public Animator transition;
    public float Time = 0f;
    public string trigger;

    void Update() {
        Scene S = SceneManager.GetActiveScene();
        if (S.name == "M - Credits") {
            StartCoroutine(reset());

            IEnumerator reset() {
                yield return new WaitForSeconds(78);
                SceneManager.LoadScene(1);
            }
        }
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("quit");
    }

    public void loadGame() {
        StartCoroutine(loadLevel(2));
    }

    public void loadCredits() {
        StartCoroutine(loadLevel(0));
    }

    IEnumerator loadLevel(int levelIndex) {
        transition.SetTrigger(trigger);
        yield return new WaitForSeconds(Time);
        SceneManager.LoadScene(levelIndex);
    }
}