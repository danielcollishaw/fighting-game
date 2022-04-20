using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float timeRemaining = 30;

    private GameObject player1;
    private GameObject player2;

    // Start is called once for initialization
    void Start()
    {
      player1 = GameObject.Find("playerOne");
      player2 = GameObject.Find("playerTwo");
    }

    // Update is called once per frame
    void Update()
    {
      float hp1 = player1.GetComponent<PlayerMain>().getHp();
      float hp1Max = player1.GetComponent<PlayerMain>().getMaxHp();
      float hp2 = player2.GetComponent<PlayerMain>().getHp();
      float hp2Max = player2.GetComponent<PlayerMain>().getMaxHp();

      // End game if someone dies
      if (hp1 <= 0 || hp2 <= 0)
        timeRemaining = 0;

      if (timeRemaining > 0)
      {
        timeRemaining -= Time.deltaTime;
      }
      else
      {
        // Time ran out highest dmg dealt wins
        if (hp1 / hp1Max > hp2 / hp2Max)
        {
          Debug.Log("player one wins");
        }
        else if (hp1 / hp1Max < hp2 / hp2Max)
        {
          Debug.Log("player two wins");
        }
        else
        {
          Debug.Log("draw");
        }
      }
      gameObject.GetComponent<Text>().text = Mathf.Ceil(timeRemaining).ToString();
    }
}
