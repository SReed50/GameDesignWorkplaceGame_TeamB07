using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public float theTimer;
    public Text timerText;
    public float startTime = 20;

    public bool isEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        theTimer = startTime;
        if (isEnd) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
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
        timerText.text = "Time: " + Mathf.Floor(theTimer);
        if ((theTimer <= 0)&&(isEnd == false)) {
            SceneManager.LoadScene("EndLose");
        }
    }

    public void QuitGame() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
