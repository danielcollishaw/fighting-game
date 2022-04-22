using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    public void charSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    public void controlSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controls");
    }

    public void menuSelect()
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }
}
