using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//Classe qui gère l'affichage du nombre de balles restantes
public class NbBallesManager : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI textComponent;

    // Update is called once per frame
    void Update()
    {
        GestionTexte();
    }

    public void GestionTexte(){
        textComponent.text = "Nombre de balles: " + ArmeController.nbBalles + "/" + ArmeController.nbBallesMax;
    }
}
