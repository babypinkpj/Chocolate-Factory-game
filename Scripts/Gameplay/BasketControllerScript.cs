using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketControllerScript : MonoBehaviour
{
   // Design functions for moving basket by keyboard
   /* public KeyCode moveForwardKey = KeyCode.W;
   public KeyCode moveBackKey = KeyCode.S;
   public KeyCode turnLeftKey = KeyCode.A;
   public KeyCode turnRightKey = KeyCode.D; */
   public int moveSpeed = 100;
   public int turnSpeed = 50;
   //public AudioSource audioSource;
   public AudioClip audioClip;
   public AudioSource audioSource;

   void Start()
   {
    audioSource = GetComponent<AudioSource>();
   }


   public void MoveBasket(float direction)
   {
transform.Translate(Vector3.forward * direction * moveSpeed * Time.deltaTime);
   }
   public void RotateBasket(float direction)
   {
  
      transform.Rotate(Vector3.up, direction * turnSpeed * Time.deltaTime);
    
   }
   /* void DetectInput()
   {
   
     if (Input.GetKey(moveForwardKey)) { MoveBasket(-1); }
     if (Input.GetKey(moveBackKey)) { MoveBasket(1); }
     if (Input.GetKey(turnRightKey)) { RotateBasket(1); }
     if (Input.GetKey(turnLeftKey)) { RotateBasket(-1); }

   } */
   /* void Update()
   {
    DetectInput();
   } */
}
