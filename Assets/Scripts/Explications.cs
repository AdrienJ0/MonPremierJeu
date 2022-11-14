using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

//Scriptable object qui permet de donner quelques infos utiles à l'utilisateur pendant la partie.
public class Explications : ScriptableObject
{
    public List<string> ExplicationStrings = new List<string>();

    //Explications[0] = "Salut " + Player.pseudo +" et bienvenue sur Zombie Land!";
    //Explications[1] = "Ton objectif est de tuer le maximum de zombies! A chaque zombie tué, tu obtiendras 5 points.";
    //Explications[2] = "Voici quelques commandes utiles: \n- Pour tirer, fait un <b>clic gauche</b>. \n- Pour metter pause, appuie sur <b>P</b>.";
}
