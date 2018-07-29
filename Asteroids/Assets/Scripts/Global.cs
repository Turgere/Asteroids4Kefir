using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public static class Global {

    private static List<LevelSetup> LevelSetupsList;
    private static List<Level> LevelsList;

    public enum GameObjectTypes {
        Player,
        AsteroidBig,
        AsteroidMedium,
        AsteroidSmall,
        Saucer,
        Bullet,
        LazerBeam
    }

    public static void Init() {
        CreateLevelSetups();
        CreateLevelList();
    }

    public static Level getLevelBuyId(int id) {

        var desiredLevel = LevelsList.Where(level => level.Id == id).FirstOrDefault();

        if (desiredLevel == null) {
            desiredLevel = LevelsList[0];
        }

        return desiredLevel;
    }

    private static void CreateLevelSetups() {
        LevelSetupsList = new List<LevelSetup>();

        LevelSetup anotherLevelSetup = new LevelSetup();
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.Player,1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidBig, 1);
        LevelSetupsList.Add(anotherLevelSetup);

        anotherLevelSetup = new LevelSetup();
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.Player, 1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidBig, 1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidMedium, 1);
        LevelSetupsList.Add(anotherLevelSetup);

        anotherLevelSetup = new LevelSetup();
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.Player, 1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidBig, 2);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidMedium, 1);
        LevelSetupsList.Add(anotherLevelSetup);

        anotherLevelSetup = new LevelSetup();
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.Player, 1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidBig, 1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidMedium, 1);
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.AsteroidSmall, 1);
        LevelSetupsList.Add(anotherLevelSetup);
    }

    private static void CreateLevelList() {
        LevelsList = new List<Level>();

        LevelsList.Add(new Level(1, LevelSetupsList[0]));
        LevelsList.Add(new Level(2, LevelSetupsList[1]));
        LevelsList.Add(new Level(3, LevelSetupsList[2]));
        LevelsList.Add(new Level(4, LevelSetupsList[3]));
    }

}
