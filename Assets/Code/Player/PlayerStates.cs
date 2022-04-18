// Written by Daniel Collishaw
// This is class handles the states used in animation and sound design

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates
{
  private bool idle = true;
  private bool running = false;
  private bool jumping = false;
  private bool attacking = false;
  private bool special = false;

  public void setIdle(bool state)
  {
    this.idle = state;
  }

  public void setRunning(bool state)
  {
    this.running = state;
  }

  public void setJumping(bool state)
  {
    this.jumping = state;
  }

  public void setAttacking(bool state)
  {
    this.attacking = state;
  }

  public bool getAttacking()
  {
    return this.attacking;
  }

  public void setSpecial(bool state)
  {
    this.special = state;
  }

  public bool getSpecial()
  {
    return this.special;
  }

  public void setAnimator(Animator animator)
  {
    animator.SetBool("idle", this.idle);
    animator.SetBool("running", this.running);
    animator.SetBool("jumping", this.jumping);
    animator.SetBool("attacking", this.attacking);
    animator.SetBool("special", this.special);

    if (this.attacking)
      updateAttack(animator, 1);
    else if (this.special)
      updateAttack(animator, 2);
  }

  private void updateAttack(Animator animator, int attack)
  {
    bool temp = animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1;
    if (attack == 1)
      this.attacking = temp;
    else if (attack == 2)
      this.special = temp;
  }
}
