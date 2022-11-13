using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PseudoManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;

    // Update is called once per frame
    void Update()
    {
        GestionTexte();
    }

    public void GestionTexte(){
        //Debug.Log(Player.getPseudo());
        textComponent.text = Player.getPseudo();
    }
}
