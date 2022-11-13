using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private Transform cameraTransform;

    [SerializeField] private float speed = 1f;

    [SerializeField] private float mouseSensitivity = 1f;
    private float yawn = 0.0f;  //Pour les déplacements horizontaux de souris
    private float pitch = 0.0f; //Pour les déplacments verticaux de souris

     [SerializeField] private BoxCollider cibleSpawnZone = default;
    private Bounds fieldBounds;

    [SerializeField] private AudioClip sonStart;

    void Awake()
    {
        fieldBounds = cibleSpawnZone.bounds;
        Cursor.lockState = CursorLockMode.Locked;
        //Debug.Log("Lu");
    } 

    void Start(){
        GetComponent<AudioSource>().PlayOneShot(sonStart);
    }

    private void Update()
    {
        if(MenuPauseManager.gameIsPaused == false){
            HandleKeyBoardMovement();
            HandleMouseMovement();
        }
        
    }


    private void HandleKeyBoardMovement(){

        Vector3 currentPosition = cameraTransform.position;
        Vector3 deltaPosition = (
            cameraTransform.right * Input.GetAxis("Horizontal")
            + cameraTransform.forward * Input.GetAxis("Vertical")
        ) * speed;
        deltaPosition.y = 0f;

        if((currentPosition.x + deltaPosition.x) > fieldBounds.min.x && (currentPosition.x + deltaPosition.x) < fieldBounds.max.x 
        && (currentPosition.z + deltaPosition.z) < fieldBounds.max.z && (currentPosition.z + deltaPosition.z) > fieldBounds.min.z){
            cameraTransform.position = currentPosition + deltaPosition;
        }
        else{
            Debug.Log("Hors-limite!");
        }
         

    }

    private void HandleMouseMovement(){

        yawn += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        cameraTransform.eulerAngles = new Vector3(pitch, yawn, 0f);

    }

}
