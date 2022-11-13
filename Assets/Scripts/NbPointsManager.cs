using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NbPointsManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;

    // Update is called once per frame
    void Update()
    {
        GestionTexte();
    }

    public void GestionTexte(){
        textComponent.text = "Nombre de points: " + Player.getNbPoints();
    }
}
