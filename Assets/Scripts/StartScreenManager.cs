using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenManager : MonoBehaviour
{
    private int nbSecondes = 3;
    public Slider slider;
   
    void Start()
    {
        StartCoroutine("Attendre");
    }

    IEnumerator Attendre(){

        slider.value = 0.5f;

        yield return new WaitForSeconds(nbSecondes);

        slider.value = 1f;
        
        SceneManager.LoadScene("MainMenu");
        
    }
}
