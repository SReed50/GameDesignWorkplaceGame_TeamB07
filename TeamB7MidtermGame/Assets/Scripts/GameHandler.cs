using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public float theTimer;
    public Text timerText;
    private float startTime = 121;

    public bool isEnd = true;
    public GameObject tornado;

    // Start is called before the first frame update
    void Start()
    {
        theTimer = startTime;
        tornado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape")) {
                 QuitGame();
        }
    }

    void FixedUpdate() {
        theTimer -= Time.deltaTime;
        if (theTimer > 0) {
            timerText.text = "" + Mathf.Floor(theTimer);
        } else {
            StartCoroutine(NaturalDisaster());
        }
    }

    public void QuitGame() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    IEnumerator NaturalDisaster() {
        tornado.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("MainMenu");
        // game over goes here
    }
}
