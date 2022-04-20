// Written by Daniel Collishaw
// This is class is decides which character animation should be played following selection

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl
{
  public void setAnimator(Animator animator, string character)
  {
    string path = "Characters/" + character;
    animator.runtimeAnimatorController = Resources.Load(path) as RuntimeAnimatorController;
  }
}
