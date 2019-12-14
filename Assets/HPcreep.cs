using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPcreep : MonoBehaviour
{
    public float hp;
    float dam;
    public Transform creepdeath;

    // Start is called before the first frame update
    void Start()
    {
        
        //Damage damage = new Damage(); // тут недолжно быть создание новой перменной, тут нужно вытянуть как то то значение, которое задаётся непосредственно в скрипте дамага
        // dam = damage.damage;
        //Debug.unityLogger.Log("damAGA", damage.damage);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            dam = other.gameObject.GetComponent<Damage>().damage;
            Debug.unityLogger.Log("damAGA", dam);
            hp = hp - dam;
            Destroy(other.gameObject);
            //Debug.unityLogger.Log("hpCREEP", hp);

            if (hp < 1)
            {
                //creepdeath = gameObject.transform; //gameObject.transform.position;
                Destroy(gameObject);

            }
        }
    }




}
