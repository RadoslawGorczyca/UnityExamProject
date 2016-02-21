using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class LevelManager : MonoBehaviour {
    //public static LevelManager Instance;

    public GlobalObject global;

    public Transform mainMenu, optionsMenu, pauseMenu;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fps;

    public PlayerStatistics savedPlayerData = new PlayerStatistics();

    public GameObject art1, art2, art3;

    void Start()
    {
        global = GameObject.FindObjectOfType<GlobalObject>();
        global.arf1 = art1;
        global.arf2 = art2;
        global.arf3 = art3;

        global.artefakty();
    }


    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }

    public void QuitScene()
    {
        Application.Quit();
    }

    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        } else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void Back()
    {
        fps.Pausing();
    }

    public void Save()
    {
        global.Save();
    }

    public void Load()
    {
        global.Load();

        if (global.savedPlayerData.SceneID == 1)
            LoadScene("Las");
        if (global.savedPlayerData.SceneID == 2)
            LoadScene("Level1");
        if (global.savedPlayerData.SceneID == 3)
            LoadScene("Level2");
    }

}
