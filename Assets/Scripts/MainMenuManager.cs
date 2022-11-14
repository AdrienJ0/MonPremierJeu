using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Classe qui permet de gérer l'affichage du menu principal
public class MainMenuManager : MonoBehaviour
{

    public GameObject rulesWindow;
    public GameObject pseudoWindow;
    public TextMeshProUGUI pseudoInput;
    private string _pseudo;

    //Gère l'appui sur le bouton Commencer
    public void StartGame(){

        _pseudo = pseudoInput.text;
        Player.pseudo = _pseudo;
        
        SceneManager.LoadScene("IntroScene"); //Mettre l'index ou le nom de la game scene en parametre
        //pseudoWindow.SetActive(false);
    }

    //Gère l'appui sur le bouton Jouer
    public void PlayButton(){
        pseudoWindow.SetActive(true);
    }

    public void OpenRulesWindow(){
        rulesWindow.SetActive(true);
    }

    public void CloseRulesWindow(){
        rulesWindow.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
    }

    
}
