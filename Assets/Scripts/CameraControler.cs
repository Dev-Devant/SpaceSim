using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour{
    
    public GameObject player;
    private float zoom = -40.0f;
    private float maxZoom = -10;
    private float minZoom = -60;
    void Start()    {
        

    }
   
    void Update() {
        transform.position = (player.transform.position)+ new Vector3(0,10,zoom);
        zoom += Input.mouseScrollDelta.y;
        
        if (zoom < minZoom){
            zoom = minZoom;
        }
        if (zoom > maxZoom){
            zoom = maxZoom;
        }

    }
}
