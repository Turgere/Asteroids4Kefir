using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public static class Global
{

    private static List<LevelSetup> LevelSetupsList;
    private static List<Level> LevelsList;
    private static Dictionary<GameObjectTypes, Sprite> spriteSettingsForGameObjectTypes;

    public enum GameObjectTypes
    {
        Player,
        AsteroidBig,
        AsteroidMedium,
        AsteroidSmall,
        Saucer,
        Bullet,
        LazerBeam
    }

    public static void Init()
    {
        CreateLevelSetups();
        CreateLevelList();
        SetupObjectSprites();
    }

    public static Level getLevelBuyId(int id)
    {
        Level desiredLevel = LevelsList.Where(level => level.Id == id).FirstOrDefault();

        if (desiredLevel == null)
        {
            desiredLevel = LevelsList[0];
        }

        return desiredLevel;
    }

    private static void CreateLevelSetups()
    {
        LevelSetupsList = new List<LevelSetup>();

        LevelSetup anotherLevelSetup = new LevelSetup();
        anotherLevelSetup.addObjectToLevelMap(Global.GameObjectTypes.Player, 1);
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

    private static void CreateLevelList()
    {
        LevelsList = new List<Level>();

        LevelsList.Add(new Level(1, LevelSetupsList[0]));
        LevelsList.Add(new Level(2, LevelSetupsList[1]));
        LevelsList.Add(new Level(3, LevelSetupsList[2]));
        LevelsList.Add(new Level(4, LevelSetupsList[3]));
    }

    private static void SetupObjectSprites()
    {
        Sprite anotherSprite;
        spriteSettingsForGameObjectTypes = new Dictionary<GameObjectTypes, Sprite>();

        anotherSprite = Resources.Load<Sprite>("Player") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.Player, anotherSprite);

        anotherSprite = Resources.Load<Sprite>("AsteroidBig") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.AsteroidBig, anotherSprite);

        anotherSprite = Resources.Load<Sprite>("AsteroidMedium") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.AsteroidMedium, anotherSprite);

        anotherSprite = Resources.Load<Sprite>("AsteroidSmall") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.AsteroidSmall, anotherSprite);

        anotherSprite = Resources.Load<Sprite>("Saucer") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.Saucer, anotherSprite);

        anotherSprite = Resources.Load<Sprite>("Bullet") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.Bullet, anotherSprite);

        anotherSprite = Resources.Load<Sprite>("LazerBeam") as Sprite;
        spriteSettingsForGameObjectTypes.Add(GameObjectTypes.LazerBeam, anotherSprite);
    }

    public static Sprite getSpriteBuyGameObjectType(GameObjectTypes objectType)
    {
        Sprite anotherSprite = spriteSettingsForGameObjectTypes[objectType];

        return anotherSprite;
    }
}
