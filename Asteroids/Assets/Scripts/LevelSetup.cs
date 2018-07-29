using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetup
{

    private Dictionary<Global.GameObjectTypes, int> levelObjectsMap;
    public Dictionary<Global.GameObjectTypes, int> LevelObjectsMap
    {
        get
        {
            return levelObjectsMap;
        }

        private set
        {
            levelObjectsMap = value;
        }
    }

    public LevelSetup()
    {
        LevelObjectsMap = new Dictionary<Global.GameObjectTypes, int>();
    }
       

    public void addObjectToLevelMap(Global.GameObjectTypes gameObjectType, int count)
    {
        LevelObjectsMap.Add(gameObjectType, count);
    }
}
