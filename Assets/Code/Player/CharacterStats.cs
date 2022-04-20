// Written by Daniel Collishaw
// This class handles the stat balancing of each character

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats
{
    private float hp;
    private float speed;
    private float dashMult;

    private float attackRange;
    private float attackDmg;
    private float specialDmg;
    // per second
    private float attackRate;
    private float specialRate;


    public CharacterStats(string character)
    {
      hp = 0;
      speed = 0;
      dashMult = 0;
      attackRange = 0;
      attackDmg = 0;
      specialDmg = 0;
      attackRate = 0;
      specialRate = 0;

      if (character == "sam_man")
        sam_man();
      else if (character == "huntress")
        huntress();
      else if (character == "wizard")
        wizard();
      else if (character == "mar_man")
        mar_man();
      else if (character == "med_man")
        med_man();
      else if (character == "hero")
        hero();
      else if (character == "war_man")
        war_man();
    }

    public float getHp()
    {
      return hp;
    }

    public float getSpeed()
    {
      return speed;
    }

    public float getDashMult()
    {
      return dashMult;
    }

    public float getAttackRange()
    {
      return attackRange;
    }

    public float getAttackDmg()
    {
      return attackDmg;
    }

    public float getSpecialDmg()
    {
      return specialDmg;
    }

    public float getAttackRate()
    {
      return attackRate;
    }

    public float getSpecialRate()
    {
      return specialRate;
    }

    private void sam_man()
    {
      hp = 300;
      speed = 5f;
      dashMult = 35f;

      attackRange = 2f;
      attackDmg = 30f;
      specialDmg = 50f;
      attackRate = 0.7f;
      specialRate = 0.5f;
    }

    private void huntress()
    {
      hp = 300f;
      speed = 6.7f;
      dashMult = 36f;

      attackRange = 1.5f;
      attackDmg = 40f;
      specialDmg = 60f;
      attackRate = 0.8f;
      specialRate = 0.6f;
    }

    private void wizard()
    {
      hp = 260f;
      speed = 5.5f;
      dashMult = 33f;

      attackRange = .8f;
      attackDmg = 70f;
      specialDmg = 150f;
      attackRate = .6f;
      specialRate = 0.2f;
    }

    private void mar_man()
    {
      hp = 350f;
      speed = 5f;
      dashMult = 35f;

      attackRange = 2.3f;
      attackDmg = 50f;
      specialDmg = 70f;
      attackRate = .9f;
      specialRate = .55f;
    }

    private void med_man()
    {
      hp = 500f;
      speed = 3.6f;
      dashMult = 25f;

      attackRange = 2.3f;
      attackDmg = 70f;
      specialDmg = 140f;
      attackRate = .5f;
      specialRate = .15f;
    }

    private void hero()
    {
      hp = 400f;
      speed = 4.2f;
      dashMult = 30f;

      attackRange = 2f;
      attackDmg = 40f;
      specialDmg = 60f;
      attackRate = .9f;
      specialRate = .6f;
    }

    private void war_man()
    {
      hp = 350f;
      speed = 5f;
      dashMult = 40f;

      attackRange = 2.3f;
      attackDmg = 30f;
      specialDmg = 90f;
      attackRate = 1.3f;
      specialRate = .5f;
    }
}
