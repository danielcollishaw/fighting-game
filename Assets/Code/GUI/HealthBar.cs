using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private string playerName;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.Find(playerName);
    }

    // Update is called once per frame
    void Update()
    {
      float hp = player.GetComponent<PlayerMain>().getHp();
      float maxHp = player.GetComponent<PlayerMain>().getMaxHp();

      gameObject.GetComponent<Image>().fillAmount = Mathf.Clamp(hp / maxHp, 0, 1f);
    }
}
