using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreep : MonoBehaviour
{

    public float maxSpeed;
    //public GameObject Creep;
    public float minSpeed;
    public GameObject _tower;
    Vector3 _target;



    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody creep = GetComponent<Rigidbody>();
        //creep.velocity = Vector3.back * Random.Range(minSpeed, maxSpeed);

    }

    public void TakeTarget()
    {
        _target = new Vector3(_tower.transform.position.x, _tower.transform.position.y, _tower.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, 1 * Time.deltaTime);
    }
}
