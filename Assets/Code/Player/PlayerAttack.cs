// Written by Daniel Collishaw
// This class handles the attacking capabilities of the players

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack
{
    private Transform player;
    private Transform attackPoint;
    private LayerMask enemyLayers;

    private float attackRange;
    private float attackDmg;
    private float specialDmg;
    // Attacks per second
    private float attackRate;
    // Special attacks per second
    private float specialRate;

    private float nextAttackTime = 0f;

    private AudioSource attAudio;
    private AudioSource spcAudio;

    public PlayerAttack(GameObject gameObject, CharacterStats stats)
    {
      player = gameObject.transform;
      attackPoint = gameObject.transform.GetChild(0);
      enemyLayers = LayerMask.GetMask("Player");

      attackRange = stats.getAttackRange();
      attackDmg = stats.getAttackDmg();
      specialDmg = stats.getSpecialDmg();
      attackRate = stats.getAttackRate();
      specialRate = stats.getSpecialRate();

      attAudio = GameObject.Find("attackFX").GetComponent<AudioSource>();
      spcAudio = GameObject.Find("specialFX").GetComponent<AudioSource>();
    }

    public void calcAttack(PlayerStates states, PlayerControlMap map, GameObject gameObject)
    {
      if (Time.time >= nextAttackTime)
      {
        if (Input.GetKeyDown(map.getAttack()))
        {
          states.setAttacking(true);
          attack(attackDmg, attackRange);
          attAudio.Play();

          // Applying a cooldown effect
          nextAttackTime = Time.time + 1f / attackRate;
        }
        
        if (Input.GetKeyDown(map.getSpecial()))
        {
          states.setSpecial(true);
          attack(specialDmg, attackRange);
          spcAudio.Play();

          // Applying a cooldown effect
          nextAttackTime = Time.time + 1f / specialRate;
        }
      }
    }

    private void attack(float dmg, float range)
    {
      // Detect all enemies hit
      Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, range, enemyLayers);
      // Damage
      foreach(Collider2D enemy in hitEnemies)
      {
        if(enemy.name == player.name)
          continue;

        enemy.GetComponent<PlayerMain>().takeDamage(dmg);
      }
    }
}
