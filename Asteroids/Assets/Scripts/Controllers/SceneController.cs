using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    LevelController levelController;
    public GameObject objectHierarchy;
    public GameObject objectPrefab;

    void Start()
    {
        Global.Init();
        levelController = LevelController.getInstance();
        levelController.GameObjectHyerarchy = objectHierarchy;
        levelController.ObjectPrefab = objectPrefab;
        levelController.InitLevel(Global.getLevelBuyId(1));

        Camera mainCamera = Camera.main;         
        levelController.ScreenSizeInGlobalCoords = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));


    }

    void Update()
    {

    }

    private void CreateObjects()
    {


    }
}
