using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level {
 
    private int id;
    public int Id
    {
        get
        {
            return id;
        }

        private set
        {
            id = value;
        }
    }
    
    private List<GameObjectScript> gameObjectList;
    public List<GameObjectScript> GameObjectList
    {
        get
        {
            return gameObjectList;
        }

        private set
        {
            gameObjectList = value;
        }
    }

    private LevelSetup currentLevelSetup;
    public LevelSetup CurrentLevelSetup
    {
        get
        {
            return currentLevelSetup;
        }

        private set
        {
            currentLevelSetup = value;
        }
    }

    public Level(int id, LevelSetup levelSetup)
    {
        Id = id;
        CurrentLevelSetup = levelSetup;        
    }




}
