using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack
{
    public void calcAttack(PlayerStates states, PlayerControlMap map, GameObject gameObject)
    {
      // If not attacking check for attack
      if (!states.getAttacking() && !states.getSpecial())
      {
        if (Input.GetKey(map.getAttack()))
        {
          states.setAttacking(true);
        }

        if (Input.GetKey(map.getSpecial()))
        {
          states.setSpecial(true);
        }
      }
    }
}
