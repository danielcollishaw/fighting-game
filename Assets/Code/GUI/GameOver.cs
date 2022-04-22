using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool played = false;
    // Update is called once per frame
    void Update()
    {
        if (Timer.timeRemaining <= 0 && !played)
        {
          gameObject.GetComponent<AudioSource>().Play();
          played = true;
        }

    }
}
