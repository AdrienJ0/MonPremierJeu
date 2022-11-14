using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

//Classe qui permet de gérer le texte qui s'affiche dans le menu Description
public class DescriptionManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private Explications explications;

    public static bool gameIsPaused = true;

    private static int cptClickSuivant = 0; //Compte le nombre de click sur le bouton Suivant



    void Start(){
        textComponent.text = explications.ExplicationStrings[0];
    }

    
    //Génère l'explication suivante après un appui sur le bouton Suivant
    public void NextExplication(){
        if(explications != null){


            if(cptClickSuivant < explications.ExplicationStrings.Count -1){
                cptClickSuivant++;
                textComponent.text = explications.ExplicationStrings[cptClickSuivant];
            }
            else if(cptClickSuivant == explications.ExplicationStrings.Count -1){
                CloseScene();
            }

        }
        

    }

    public void CloseScene(){
        SceneManager.LoadScene("GameScene");
    }

}
