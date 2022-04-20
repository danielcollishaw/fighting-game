using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject CharacterEditor;
    public GameObject StartButton;

    public GameObject char1select1button;
    public GameObject char1select2button;
    public GameObject char1select3button;
    public GameObject char1select4button;
    public GameObject char1select5button;
    public GameObject char1select6button;
    public GameObject char1select7button;

    public GameObject char2select1button;
    public GameObject char2select2button;
    public GameObject char2select3button;
    public GameObject char2select4button;
    public GameObject char2select5button;
    public GameObject char2select6button;
    public GameObject char2select7button;

    string Character1Selection = "huntress";
    string Character2Selection = "huntress";

    // Start is called before the first frame update
    void Start()
    {
        CharacterEditor = GameObject.Find("CharacterEditor");
        CharacterEditor.SetActive(true);
    }

    public void startGame()
    {
        Debug.Log("Starting Game");
        CharacterEditor.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void setAllChar1ButtonsDefaultColor()
    {
        //char1select1button.colors = theColor;
    }

    public void setAllChar2ButtonsDefaultColor()
    {
        //char1select1button.colors = theColor;
    }

    // Character 1 Buttons
    public void char1select1()
    {
        Character1Selection = "war_man";
    }

    public void char1select2()
    {
        Character1Selection = "hero";
    }

    public void char1select3()
    {
        Character1Selection = "huntress";
    }

    public void char1select4()
    {
        Character1Selection = "mar_man";
    }

    public void char1select5()
    {
        Character1Selection = "med_man";
    }

    public void char1select6()
    {
        Character1Selection = "sam_man";
    }

    public void char1select7()
    {
        Character1Selection = "wizard";
    }

    // Character 2 Buttons
    public void char2select1()
    {
        Character2Selection = "war_man";
    }

    public void char2select2()
    {
        Character2Selection = "hero";
    }

    public void char2select3()
    {
        Character2Selection = "huntress";
    }

    public void char2select4()
    {
        Character2Selection = "mar_man";
    }

    public void char2select5()
    {
        Character2Selection = "med_man";
    }

    public void char2select6()
    {
        Character2Selection = "sam_man";
    }

    public void char2select7()
    {
        Character2Selection = "wizard";
    }

}
