using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreep : MonoBehaviour
{
    public float minDelay;
    public float maxDelay;
    public GameObject creep;
    private float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // заспавнить одного крипа
        /*float XPosition = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
        Vector3 creepPosition = new Vector3(XPosition, transform.position.y, transform.position.z - 2);
        Instantiate(creep, creepPosition, Quaternion.identity);*/
    }

    // Update is called once per frame
    void Update()
    {
         if (Time.time > nextSpawn)
         {
             float XPosition = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
             Vector3 creepPosition = new Vector3(XPosition, transform.position.y, transform.position.z-2);
             Instantiate(creep, creepPosition, Quaternion.identity);
             nextSpawn = Time.time + Random.Range(minDelay, maxDelay);
         } 
    }
}
