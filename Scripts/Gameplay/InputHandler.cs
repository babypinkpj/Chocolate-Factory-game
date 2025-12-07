using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [Header("Controller Settings")]
    public BasketControllerScript _basket;

 /*    public KeyCode moveForwardKey = KeyCode.W;
    public KeyCode moveBackKey = KeyCode.S;
    public KeyCode turnLeftKey = KeyCode.A;
    public KeyCode turnRightKey = KeyCode.D;

    private ICommand moveForward;
    private ICommand moveBack;
    private ICommand turnLeft;
    private ICommand turnRight; */

  /*   void Start()
    {
        moveForward = new MoveCommand(basketController, -1);
        moveBack = new MoveCommand(basketController, 1);
        turnLeft = new RotateCommand(basketController, -1);
        turnRight = new RotateCommand(basketController, 1);
    } */

    void Update()
    {
       if (Input.GetKey(KeyCode.W)) 
       {
        ICommand move = new MoveCommand(_basket, 1f);
        CommandManager.Instance.RunCommand(move);     
          }
    if (Input.GetKeyDown(KeyCode.Z))
    {
        CommandManager.Instance.UndoLastCommand();
    }

    if(Input.GetKey(KeyCode.S)) 
       {
        ICommand move = new MoveCommand(_basket, -1f);
        CommandManager.Instance.RunCommand(move);     
          }
    if(Input.GetKey(KeyCode.A))
         {
          ICommand rotate = new RotateCommand(_basket, -1f);
          CommandManager.Instance.RunCommand(rotate);     
             }
    if(Input.GetKey(KeyCode.D))
    {
            ICommand rotate = new RotateCommand(_basket, 1f);
            CommandManager.Instance.RunCommand(rotate);     
                }
    }
   /*  void HandleInput()
    {
        if (Input.GetKey(moveForwardKey)) { moveForward.Execute(); }
        if (Input.GetKey(moveBackKey)) { moveBack.Execute(); }
        if (Input.GetKey(turnLeftKey)) { turnLeft.Execute(); }
        if (Input.GetKey(turnRightKey)) { turnRight.Execute(); }
    } */
}