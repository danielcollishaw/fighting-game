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

    public static string Character1Selection = "huntress";
    public static string Character2Selection = "huntress";
    public static string Stage = "storm";

    private AudioSource select;

    // Start is called before the first frame update
    void Start()
    {
        CharacterEditor = GameObject.Find("CharacterEditor");
        CharacterEditor.SetActive(true);
        select = GameObject.Find("select").GetComponent<AudioSource>();
    }

    public void startGame()
    {
        CharacterEditor.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    // Character 1 Buttons
    public void char1select1()
    {
        Character1Selection = "war_man";
        select.Play();
    }

    public void char1select2()
    {
        Character1Selection = "hero";
        select.Play();
    }

    public void char1select3()
    {
        Character1Selection = "huntress";
        select.Play();
    }

    public void char1select4()
    {
        Character1Selection = "mar_man";
        select.Play();
    }

    public void char1select5()
    {
        Character1Selection = "med_man";
        select.Play();
    }

    public void char1select6()
    {
        Character1Selection = "sam_man";
        select.Play();
    }

    public void char1select7()
    {
        Character1Selection = "wizard";
        select.Play();
    }

    // Character 2 Buttons
    public void char2select1()
    {
        Character2Selection = "war_man";
        select.Play();
    }

    public void char2select2()
    {
        Character2Selection = "hero";
        select.Play();
    }

    public void char2select3()
    {
        Character2Selection = "huntress";
        select.Play();
    }

    public void char2select4()
    {
        Character2Selection = "mar_man";
        select.Play();
    }

    public void char2select5()
    {
        Character2Selection = "med_man";
        select.Play();
    }

    public void char2select6()
    {
        Character2Selection = "sam_man";
        select.Play();
    }

    public void char2select7()
    {
        Character2Selection = "wizard";
        select.Play();
    }

    public void stageselect1()
    {
        Stage = "bar";
        select.Play();
    }

    public void stageselect2()
    {
        Stage = "storm";
        select.Play();
    }

}
