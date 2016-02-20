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
    public bool IsSceneBeingLoaded = false;

    public GameObject Player;

    public PlayerStatistics savedPlayerData = new PlayerStatistics();


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
        //if(savedPlayerData.PositionY != 0)
        //Player.transform.position = new Vector3(356.9629f, 357.331f, 245.9843f);
        fps = GameObject.FindObjectOfType<FirstPersonController>();
        fpsTransform = GameObject.Find("FPSController").transform;

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Save()
    {
        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");
        LocalCopyOfData.PositionX = fpsTransform.transform.position.x;
        LocalCopyOfData.PositionY = fpsTransform.transform.position.y;
        LocalCopyOfData.PositionZ = fpsTransform.transform.position.z;

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
    }
}
