// Written by Daniel Collishaw
// This class handles victory and timing conditions

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public static float timeRemaining = 30;

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
        gameObject.GetComponent<Text>().text = Mathf.Ceil(timeRemaining).ToString();
      }
      else
      {
        if (timeRemaining > -10)
        {
          Text overlay = GameObject.Find("overScreen").GetComponent<Text>();
          // Time ran out highest dmg dealt wins
          if (hp1 / hp1Max > hp2 / hp2Max)
          {
            overlay.text = "Player one wins!";
          }
          else if (hp1 / hp1Max < hp2 / hp2Max)
          {
            overlay.text = "Player two wins!";
          }
          else
          {
            overlay.text = "It's a draw!";
          }


          StartCoroutine(waitSceneChange());
          timeRemaining = -500;
        }
      }
    }

    IEnumerator waitSceneChange()
    {
      yield return new WaitForSeconds(5);
      UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }
}
