using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour{

    private GameObject player ;
    private string state = "Idle";
    public float speed = 10.0f;
    public float damage = 10.0f;
    public float range = 50.0f;

    void Start()    {
        player = GameObject.Find("Player");
    }

    void Update()    {
        // determinate vector to aprouch player and the distance to attact
        Vector3 direction = (transform.position-player.transform.position );
        float distance = direction.magnitude ;

        if (distance < range){
            


        }

        transform.Translate(direction.normalized * Time.deltaTime * speed);
        transform.LookAt(player.transform.position);
    }

    //function to generate random point in circle
    Vector3 randomPointInCircle(Vector3 center, float radius){
        float magnitude = Random.Range(0,radius);   
        Vector3 generatedPoint = Random.insideUnitSphere*magnitude;
        return center + generatedPoint;
    }

    
    // States
    string idle(Vector3 direction,float distance){
        float idleTime = Random.Range(0,3);

        return "Idle";
    }

    


}
