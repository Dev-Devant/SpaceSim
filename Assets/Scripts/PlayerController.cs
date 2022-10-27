using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    
    private float velocity = 30.0f;
    private float maxDistance = 60;
    private Vector3 direction = Vector3.zero;
    private float Ang = 0 , Angh = 0;

    void Start()   {
              
    }

    void Update()  {
        float Vertical   = Input.GetAxis("Vertical"); 
        float Horizontal = Input.GetAxis("Horizontal");     
        direction = new Vector3(Horizontal,Vertical,1);

        transform.Translate(direction * Time.deltaTime * velocity );
        transform.rotation = Quaternion.Euler(getAngles(Horizontal,Vertical));
     }


    Vector3 getAngles(float Vertical, float Horizontal){
        float angularSpeed = 0.3f;
        if (Ang > -25 && Vertical < 0){
            Ang -= angularSpeed;
        }
        if (Ang <  25 && Vertical > 0){
            Ang += angularSpeed;
        }

        if (Vertical == 0) {
            if (Ang < 0){
                Ang += angularSpeed;
            }else{
                Ang -= angularSpeed;
            }
        }
        return new Vector3(Angh,Ang,0);
    }

     
}
