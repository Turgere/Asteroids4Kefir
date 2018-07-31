using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour {

    private Global.GameObjectTypes objectType;
    
    // Use this for initialization
    void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init(Global.GameObjectTypes ObjectType) {
        objectType = ObjectType;
        gameObject.name = ObjectType.ToString();

        setSprite();
    }

    private void setSprite() {
        SpriteRenderer spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        spriteRenderer.sprite = Global.getSpriteBuyGameObjectType(objectType);
    }
}
