using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    LevelController levelController;
    
	void Start () {
        Global.Init();
        levelController = LevelController.getInstance(Global.getLevelBuyId(1));
        
    }
		
	void Update () {
        
    }

    private void CreateObjects() {


    }
}
