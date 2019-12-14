using UnityEngine;

public class AtackTower : MonoBehaviour
{
    public GameObject bullet;
    public float speedbullet;
    float hpcreep;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other) 
    {
         if (other.tag == "creep")
         {
            hpcreep = other.gameObject.GetComponent<HPcreep>().hp;
            if (hpcreep > 0)
            {
                if (Time.time > nextFire)
                {
                    Debug.unityLogger.Log("hpcreep", hpcreep);
                    nextFire = Time.time + fireRate;
                    //задаётся вектор создания пули, то есть точка её появления, и создаётся сама пуля 
                    Vector3 bulletpos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.5f);
                    GameObject bull = Instantiate(bullet, bulletpos, transform.rotation);                    
                        //создаётся переменная типа мувбулет, и присваевается к ней компонентк мувболет; к переменной pl типа трансформ присваивается вектор крипа в текущем кадре
                        // и передаётся в класс Movebullet, в метод SetTarget.
                        Movebullet mb = bull.GetComponent<Movebullet>();
                        
                        if (other.gameObject != null)
                        {
                            Vector3 plLast = other.gameObject.transform.position;
                            mb.SetTarget(plLast);
                        }              
                }
                
            }         
            
         }

    }


}
