using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe qui stocke les infos du player
public class Player : MonoBehaviour
{
    [SerializeField] public static string pseudo;
    private static int nbPoints = 0;

    public static int getNbPoints(){
        return nbPoints;
    }

    public static string getPseudo(){
        return pseudo;
    }

    public static void setPseudo(string _pseudo){
        pseudo = _pseudo;
    }

    public static void setNbPoints(int _nbPoints){
        nbPoints = _nbPoints;
    }

    public static void addNbPoints(int _nbPoints){
        nbPoints += _nbPoints;
    }
}
