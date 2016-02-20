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

    //public PlayerStatistics LocalCopyOfData;
    //public bool IsSceneBeingLoaded = false;

    //public GameObject Player;

    public PlayerStatistics savedPlayerData = new PlayerStatistics();

    void Awake()
    {
        /*
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        //if(savedPlayerData.PositionY != 0)
            //Player.transform.position = new Vector3(356.9629f, 357.331f, 245.9843f);
        fps = GameObject.FindObjectOfType<FirstPersonController>();
        fpsTransform = GameObject.Find("FPSController").transform;
        */
    }

    void Start()
    {
        //Player.transform.position = new Vector3(356.9629f, 357.331f, 245.9843f);
        global = GameObject.FindObjectOfType<GlobalObject>();
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
    }
}
