using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class GlobalObject : MonoBehaviour {
    public static GlobalObject Instance;
    public Transform fpsTransform;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fps;

    public PlayerStatistics LocalCopyOfData;
    public bool IsBeingLoaded = false;

    public GameObject Player;

    public PlayerStatistics savedPlayerData = new PlayerStatistics();

    public GameObject arf1, arf2, arf3;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        fps = GameObject.FindObjectOfType<FirstPersonController>();
        fpsTransform = GameObject.Find("FPSController").transform;


       
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

    public void Save()
    {
        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");
        LocalCopyOfData.PositionX = fpsTransform.transform.position.x;
        LocalCopyOfData.PositionY = fpsTransform.transform.position.y;
        LocalCopyOfData.PositionZ = fpsTransform.transform.position.z;
        
        if(Application.loadedLevelName == "Las")
        {
            LocalCopyOfData.SceneID = 1;
        }

        if (Application.loadedLevelName == "Level1")
        {
            LocalCopyOfData.SceneID = 2;
        }

        if (Application.loadedLevelName == "Level2")
        {
            LocalCopyOfData.SceneID = 3;
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create("Saves/save.binary");

        //LocalCopyOfData = PlayerState.Instance.localPlayerData;

        formatter.Serialize(saveFile, LocalCopyOfData);

        saveFile.Close();
    }

    public void Load()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open("Saves/save.binary", FileMode.Open);

        LocalCopyOfData = (PlayerStatistics)formatter.Deserialize(saveFile);

        savedPlayerData = LocalCopyOfData;

        saveFile.Close();

        IsBeingLoaded = true;
    }

    public void artefakty()
    {
        if (LocalCopyOfData.Art1)
        {
            arf1.SetActive(LocalCopyOfData.Art1);
            arf3.GetComponent<Light>().enabled = false;
        }

        if (LocalCopyOfData.Art2)
        {
            arf2.SetActive(LocalCopyOfData.Art2);
        }

    }

}
