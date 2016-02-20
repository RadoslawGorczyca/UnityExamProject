using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerState : MonoBehaviour
{
    public static PlayerState Instance;

    public Transform playerPosition;

    //TUTORIAL
    public PlayerStatistics localPlayerData = new PlayerStatistics();

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Instance != this)
            Destroy(gameObject);

        GlobalObject.Instance.Player = gameObject;
        GlobalObject.Instance.fpsTransform = gameObject.transform;
        localPlayerData = GlobalObject.Instance.savedPlayerData;
        if(localPlayerData.PositionY != 0)
        playerPosition.position = new Vector3(localPlayerData.PositionX, localPlayerData.PositionY, localPlayerData.PositionZ);
    }

    //At start, load data from GlobalControl.
    void Start()
    {
        localPlayerData = GlobalObject.Instance.savedPlayerData;
    }

    void Update()
    {
        //localPlayerData.PositionX = transform.position.x;
        //localPlayerData.PositionY = transform.position.y;
        //localPlayerData.PositionZ = transform.position.z;
    }

}