using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Cette classe gère l'affichage du menu Pause
public class MenuPauseManager : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject menuPause;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            if(gameIsPaused){
                Resume();
            }
            else{
                Paused();
            }
        }
    }

    public void PauseButton(){
        if(gameIsPaused){
            Resume();
        }
        else{
            Paused();
        }
    }

    //Fonction qui met le jeu en pause
    public void Paused(){
        Cursor.lockState = CursorLockMode.None;
        menuPause.SetActive(true); //On active le menu pause
        Time.timeScale = 0; //On arrête le temps
        gameIsPaused = true;
    }

    public void Resume(){
        Cursor.lockState = CursorLockMode.Locked;
        menuPause.SetActive(false); //On désactive le menu pause
        Time.timeScale = 1; //On relance le temps
        gameIsPaused = false;
    }

    public void LoadMainMenu(){
        Resume();  //Pour éviter d'avoir le jeu en pause initialement lorsqu'on le relancera plutard
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenu");
    }
}
