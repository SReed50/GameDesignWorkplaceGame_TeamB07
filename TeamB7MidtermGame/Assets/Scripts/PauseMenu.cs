using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (gamePaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    void Pause(){
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            gamePaused = true;
    }

    public void Resume(){
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            gamePaused = false;
    }
}
