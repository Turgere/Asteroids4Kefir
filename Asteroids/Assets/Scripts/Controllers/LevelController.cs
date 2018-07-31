using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController
{
    #region Singleton
    private static LevelController instance;

    public static LevelController getInstance()
    {
        if (instance == null)
        {
            instance = new LevelController();
        }

        return instance;
    }

    private LevelController()
    {
        
    }
    #endregion

    public GameObject ObjectPrefab { get; set; }
    public GameObject GameObjectHyerarchy { get; set; }
    public Vector3 ScreenSizeInGlobalCoords { get; set; }

    private List<GameObjectScript> objectList;
      

    public void InitLevel(Level currentLevel)
    {
        InstantiateObjectsOnTheLevel(currentLevel.CurrentLevelSetup);
    }

    private void InstantiateObjectsOnTheLevel(LevelSetup levelSetup)
    {
        objectList = new List<GameObjectScript>();

        foreach (var objectType in levelSetup.LevelObjectsMap)
        {
            for (int i = 0; i < objectType.Value; i++)
            {
                GameObjectScript newObjectScript = createObjectByType(objectType.Key);
                objectList.Add(newObjectScript);
            }
        }
    }

    private GameObjectScript createObjectByType(Global.GameObjectTypes objectType)
    {
        Vector3 newObjectPosition = definePositionForCreatingObject(objectType);

        GameObject newObject = Object.Instantiate(ObjectPrefab, newObjectPosition, Quaternion.identity);

        GameObjectScript newObjectScript = newObject.GetComponentInChildren<GameObjectScript>();
        newObjectScript.Init(objectType);

        newObject.transform.SetParent(GameObjectHyerarchy.transform);

        return (newObjectScript);
    }

    private Vector3 definePositionForCreatingObject(Global.GameObjectTypes objectType) {
        //TODO
        /*
         * Написать ПП для определения наилучшего респа объектов. Объект появляется в наиболее свободной точке.
         * Игрок имеет наивысший показатель излучения.
         * Чем больше объект, тем больше он имеет показатель излучения и наоборот.
         * ПП должно быть отдельным объектом в глобале. 
         * Инстанциация происходит в глобале.
         * Обновление ПП состояния происходит при каждом добавлении или удалении объекта со сцены.
         * Настройки ПП задаются в глобале.
         * В будущем возможно сделать уклонение объектов от пуль.
         * Тарелки будут использовать ПП для нахождения оптимального пути к игроку и уклонении от него.
         */


        return Vector3.zero;
    }
}
