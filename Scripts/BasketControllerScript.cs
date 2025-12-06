using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketControllerScript : MonoBehaviour
{
   // Design functions for moving basket by keyboard
   public KeyCode moveForwardKey = KeyCode.W;
   public KeyCode moveBackKey = KeyCode.S;
   public KeyCode turnLeftKey = KeyCode.A;
   public KeyCode turnRightKey = KeyCode.D;
   public int moveSpeed = 100;
   public int turnSpeed = 50;
   //public AudioSource audioSource;
   public AudioClip audioClip;
   public AudioSource audioSource;

   void Start()
   {
    audioSource = GetComponent<AudioSource>();
   }


   void MoveBasket(float direction)
   {
   
     
    Vector3 moveVector = transform.forward * direction;
 transform.Translate(moveVector * Time.deltaTime * moveSpeed, Space.World);

 
    
   
    
       /** Vector3 moveVector = new Vector3(0,0,1);
   Debug.Log("Time.deltaTime = " + Time.deltaTime);
   transform.Translate(moveVector * Time.deltaTime * moveSpeed);*/

    

   }
   void RotateBasket(float direction)
   {
    
    
      Vector3 turnVector = new Vector3(0, direction, 0);
        transform.Rotate(turnVector * Time.deltaTime * turnSpeed);
    Debug.Log("RotateBasket");
    
   
    
        /* Vector3 turnVector = new Vector3(0,-1,0);
    transform.Rotate(turnVector * Time.deltaTime * turnSpeed);
    Debug.Log("RotateBasket");*/

    

   }
   void DetectInput()
   {
   
     if (Input.GetKey(moveForwardKey)) { MoveBasket(-1); }
     if (Input.GetKey(moveBackKey)) { MoveBasket(1); }
     if (Input.GetKey(turnRightKey)) { RotateBasket(1); }
     if (Input.GetKey(turnLeftKey)) { RotateBasket(-1); }

   }
   void Update()
   {
    DetectInput();
   }
}
