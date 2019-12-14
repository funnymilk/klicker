using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebullet : MonoBehaviour
{
    public float speedFactor = 1.0f;
    Vector3 _creep;
    //Transform target;
      
    
    public void SetTarget(Vector3 creep)
    {
        _creep = creep;
    }

  
    // Update is called once per frame 
    public void Update()
    {              
        //Vector3 _target = new Vector3(_creep.transform.position.x, _creep.transform.position.y, _creep.transform.position.z);       
        transform.position = Vector3.MoveTowards(transform.position, _creep, 5 * Time.deltaTime);
    }

}
