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
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        theTimer = startTime;
        tornado.SetActive(false);
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update() 
    {
        if ((Input.GetKeyDown("e")) && PlayerMovement.playerSafe) {
            PlayerMovement.frozen = false;
            PlayerMovement.playerSafe = false;
            player.SetActive(true);
            player.transform.position = new Vector3(0f, 1.62f, 25f);
        }
    }

    void FixedUpdate() {
        if (!(PauseMenu.gamePaused) && (theTimer > 0)) {
            theTimer -= Time.deltaTime;
            timerText.text = "" + Mathf.Floor(theTimer);
        } else {
            timerText.text = "0";
            PlayerMovement.frozen = true;
            StartCoroutine(NaturalDisaster());
        }
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        PauseMenu.gamePaused = false;
        SceneManager.LoadScene("MainMenu");
            // Please also reset all static variables here, for new games!
        theTimer = startTime;
        GameInventory.menuBuildIsOpen = false;
        PlayerMovement.frozen = false;
        PlayerMovement.playerSafe = false;
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
