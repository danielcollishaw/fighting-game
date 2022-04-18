// Written by Daniel Collishaw
// This is class defines the control mapping for current player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlMap
{
  // Player Number Constants
  private const char PLAYER_ONE = '1';
  private const char PLAYER_TWO = '2';

  // Movement members
  private KeyCode left;
  private KeyCode right;
  private KeyCode jump;
  private KeyCode dash;
  private KeyCode attack;
  private KeyCode special;

  public void setPlayerMap(char player)
  {
    if (player == PLAYER_ONE)
      this.setPlayerOne();
    if (player == PLAYER_TWO)
      this.setPlayerTwo();
  }

  private void setPlayerOne()
  {
    this.left = KeyCode.A;
    this.right = KeyCode.D;
    this.jump = KeyCode.W;
    this.dash = KeyCode.X;
    this.attack = KeyCode.C;
    this.special = KeyCode.Z;
  }

  private void setPlayerTwo()
  {
    this.left = KeyCode.LeftArrow;
    this.right = KeyCode.RightArrow;
    this.jump = KeyCode.UpArrow;
    this.dash = KeyCode.Period;
    this.attack = KeyCode.Slash;
    this.special = KeyCode.Comma;
  }

  public KeyCode getLeft()
  {
    return this.left;
  }

  public KeyCode getRight()
  {
    return this.right;
  }

  public KeyCode getJump()
  {
    return this.jump;
  }

  public KeyCode getDash()
  {
    return this.dash;
  }

  public KeyCode getAttack()
  {
    return this.attack;
  }

  public KeyCode getSpecial()
  {
    return this.special;
  }
}
