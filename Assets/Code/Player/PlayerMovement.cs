// Written by Daniel Collishaw
// This is class handles movement script for game object based on mapping

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    // Horizontal movement variables
    private float playerSpeed = 5f;
    private float dashMult = 35f;

    // Verticle movement variables
    private float groundY;
    private int jumpFrame = 0;
    private int jumpFrameApex = 30;
    private int jumpMax = 1;
    private int jumpsLeft;

    // Start is called once
    public void defineGround(GameObject gameObject)
    {
      // Initialize the ground boundary based on starting character position
      this.groundY = gameObject.transform.position.y;
    }

    // Main function of class that deals with player movement
    public void move(PlayerStates states, PlayerControlMap map, GameObject gameObject)
    {
      // Initialization of horizontal variables
      float xMovement = 0f;
      float dash = 1f;

      // If player is touching ground then reset jump count
      if (gameObject.transform.position.y <= groundY)
        this.jumpsLeft = this.jumpMax;

      // Getting user input
      if (Input.GetKey(map.getRight()))
      {
        xMovement = 1f;
        states.setRunning(true);
        states.setIdle(false);
      }
      if (Input.GetKey(map.getLeft()))
      {
        xMovement = -1f;
        states.setRunning(true);
        states.setIdle(false);
      }
      if (Input.GetKeyUp(map.getRight()) || Input.GetKeyUp(map.getLeft()))
      {
        states.setRunning(false);
        states.setIdle(true);
      }
      if (Input.GetKeyDown(map.getDash()))
      {
        dash = this.dashMult;
      }
      if(Input.GetKeyDown(map.getJump()) && jumpsLeft > 0)
      {
        Debug.Log("Jumped");
        jumpFrame = 1;
        jumpsLeft--;
        states.setJumping(true);
      }

      // Handles horizontal movement on whether movement key has been pressed
      // in frame period
      Vector3 moveHorizontal = new Vector3(xMovement, 0, 0);
      gameObject.transform.position += moveHorizontal * this.playerSpeed * dash * Time.deltaTime;

      // Handles vertical movement based on if jump is queued by user
      // Will increment height until an apex is reached
      Vector3 moveVertical = new Vector3(0, 1, 0);
      if (this.jumpFrame > 0)
      {
        gameObject.transform.position += moveVertical * this.playerSpeed * 1.5f * Time.deltaTime;

        this.jumpFrame++;

        if (this.jumpFrame == jumpFrameApex)
          states.setJumping(false);

        this.jumpFrame %= this.jumpFrameApex;
      }

      // Gravity for player
      // TODO If platforms will be added this needs work
      else if (gameObject.transform.position.y > this.groundY)
      {
        gameObject.transform.position -= moveVertical * this.playerSpeed * 1.5f * Time.deltaTime;
      }
    }
}
