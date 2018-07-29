using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController
{
    private static LevelController instance;
    private static GameObjectScript ObjectList;

    private LevelController(Level currentLevel)
    {
        InitLevel(currentLevel);
    }


    public static LevelController getInstance(Level currentLevel)
    {
        if (instance == null)
        {
            instance = new LevelController(currentLevel);
        }

        return instance;
    }

    public static void InitLevel(Level currentLevel)
    {
        InstantiateObjects(currentLevel.CurrentLevelSetup);
    }

    private static void InstantiateObjects(LevelSetup levelSetup)
    {
        foreach (var objectType in levelSetup.LevelObjectsMap)
        {
            for (int i = 0; i < objectType.Value; i++)
            {
                createObject(objectType.Key);
            }
        }
    }

    private static void createObject(Global.GameObjectTypes objectType)
    {

    }
}
