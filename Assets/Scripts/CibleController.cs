using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleController : MonoBehaviour
{
    private Rigidbody cibleRigidbody;
    [SerializeField] private Transform cibleTransform;
    [SerializeField] private float speedModifier = 0.01f;
    private static LayerMask ballLayer;

    [SerializeField] private AudioClip sonKill;

    [SerializeField] private GameObject killEffect; //Particules qui apparaissent quand on touche une cible

    private void Awake() {
            cibleRigidbody = GetComponent<Rigidbody>();
            ballLayer = LayerMask.NameToLayer("Balle");
            //StartCoroutine(Move());
    }

    private IEnumerator Move() { //A ameliorer
            while (true) {
                float timeToDoMovement = Random.Range(2f, 5f);
                float timer = 0f;
                Vector3 deltaPosition = new Vector3(Random.Range(-1f, 1f),
                                            Random.Range(-0.1f, 0.1f),
                                            Random.Range(-1f, 1f)) * speedModifier;

                while (timer < timeToDoMovement) {
                    timer += Time.deltaTime;
                    cibleRigidbody.position += deltaPosition;
                    yield return new WaitForEndOfFrame();
                }
            }
    }

    private void OnCollisionEnter(Collision other) {
            if (other.gameObject.layer == ballLayer){
                GetComponent<AudioSource>().PlayOneShot(sonKill);
                Instantiate(killEffect, cibleTransform.position, killEffect.transform.rotation); //Génère des particules de sang
                Destroy(gameObject);

                Player.addNbPoints(5);
                //Debug.Log("Bien joué! +5 points!");
                //Debug.Log(Player.getNbPoints());
            }
                
            /* if(other.gameObject.layer == murlayer){
                Debug.Log("Collision !");
            } */
    }

}
