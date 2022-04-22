// Written by Daniel Collishaw
// This class initializes the stage based on menu choice


using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StageSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      string path = "Stages/" + Menu.Stage;
      gameObject.GetComponent<Image>().sprite =  Resources.Load<Sprite>(path);
    }
}
