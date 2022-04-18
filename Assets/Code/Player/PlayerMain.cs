// Written by Daniel Collishaw
// This is class is the driving class, handling all the component classes per frame

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [SerializeField]
    private float hp;

    // Player controllers
    [SerializeField]
    private char playerNum = '1';
    private PlayerControlMap mapping = new PlayerControlMap();
    private PlayerMovement movement = new PlayerMovement();
    private PlayerAttack attack = new PlayerAttack();

    // State manipulation and animation
    [SerializeField]
    public Animator animator;
    private PlayerStates states = new PlayerStates();

    // Start initializes needed values for each component class
    void Start()
    {
      movement.defineGround(gameObject);
      mapping.setPlayerMap(playerNum);
    }

    // Update is called once per frame
    void Update()
    {
      states.setAnimator(animator);
      movement.move(states, mapping, gameObject);
      attack.calcAttack(states, mapping, gameObject);
    }
}
