// Written by Daniel Collishaw
// This class is the driving class, handling all the component classes per frame

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // Stats
    [SerializeField]
    private float hp;
    [SerializeField]
    private string character = "huntress";
    private CharacterStats stats;

    // Player controllers
    [SerializeField]
    private char playerNum = '1';
    private PlayerControlMap mapping = new PlayerControlMap();
    private PlayerMovement movement;
    private PlayerAttack attack;
    private AnimationControl control = new AnimationControl();
    private bool dead = false;

    // State manipulation and animation
    [SerializeField]
    private Animator animator;
    private PlayerStates states = new PlayerStates();

    // Start initializes needed values for each component class
    void Start()
    {
      // quick bug fix for wizard scaling
      if (character == "wizard")
        gameObject.transform.localScale = new Vector3(3, 3, 1);

      // setup stats and controllers
      stats = new CharacterStats(character);
      hp = stats.getHp();
      attack = new PlayerAttack(gameObject, stats);
      movement =  new PlayerMovement(gameObject, stats);
      mapping.setPlayerMap(playerNum);
      control.setAnimator(animator, character);
    }

    // Update is called once per frame
    void Update()
    {
      states.setAnimator(animator);

      if (dead)
        return;

      movement.move(states, mapping, gameObject);
      attack.calcAttack(states, mapping, gameObject);
    }

    public void takeDamage(float dmg)
    {
      hp -= dmg;

      if (hp <= 0)
      {
        dead = true;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, -3.6f, 0);
        states.setDead(true);
      }
    }

    public float getHp()
    {
      return hp;
    }

    public float getMaxHp()
    {
      return stats.getHp();
    }
}
