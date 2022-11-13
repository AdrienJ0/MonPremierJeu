using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmeController : MonoBehaviour
{
    //[SerializeField] private Transform armeTransform;
    [SerializeField] private Transform spawnBalleReference;
    
    private float puissanceTir = 4500f;

    [SerializeField] private GameObject ballePrefab;
    [SerializeField] private Transform balleParent;

    public const int nbBallesMax = 500;

    public static int nbBalles = nbBallesMax;

    [SerializeField] private AudioClip sonTir;
    [SerializeField] private AudioClip emptyGun;

    // Update is called once per frame
    void Update()
    {
        if(MenuPauseManager.gameIsPaused == false){
            HandleAction();
        }
        
    }

    private void SpawnBalle()
    {
        

        //On instancie la balle
        GameObject balle = Instantiate(ballePrefab, spawnBalleReference.position, Quaternion.identity, balleParent);

        //On récupère son rigidbody
        Rigidbody balleRigidbody  = balle.GetComponent<Rigidbody>();

        //On applique une force initiale à la balle
        balleRigidbody.AddForce(spawnBalleReference.forward * puissanceTir); // AddForce prend en paramètre la direction de force * son intensité

        //On réduit le nombre de balles
        if(nbBalles > 0){
            GetComponent<AudioSource>().PlayOneShot(sonTir);
            nbBalles-- ;
        }
        else{
            GetComponent<AudioSource>().PlayOneShot(emptyGun);
            nbBalles = 0;
        }
        
    }

    private void HandleAction(){
        if(Input.GetMouseButtonDown(0) && nbBalles >0){  //Tir de balle lors d'un clic gauche
            SpawnBalle();
        }
        else if(Input.GetMouseButtonDown(0) && nbBalles <= 0){
            Debug.Log("Vous n'avez plus de balles!");
        }
    }

    public int getNbBalles(){
        return nbBalles;
    }

    public int getNbBallesMax(){
        return nbBallesMax;
    }
}
