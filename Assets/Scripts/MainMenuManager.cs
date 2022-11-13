using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    public GameObject rulesWindow;
    public GameObject pseudoWindow;
    public TextMeshProUGUI pseudoInput;
    private string _pseudo;

    public void StartGame(){

        _pseudo = pseudoInput.text;
        Player.pseudo = _pseudo;
        
        SceneManager.LoadScene("GameScene"); //Mettre l'index ou le nom de la game scene en parametre
        //pseudoWindow.SetActive(false);
    }

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

    /* public void ReadPseudo(){
        input = s;
        Player.setPseudo(input);
        Debug.Log(input);
    } */
}
