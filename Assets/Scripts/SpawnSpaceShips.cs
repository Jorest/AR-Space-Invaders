using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpaceShips : MonoBehaviour
{
    float timer;
    public GameObject myPrefabObject = null;
    public float shipFrecuency=3;
    public int maxShipAmout = 5;
    int shipAmount= 0;
    bool col = false;

    void Start()
    {
        //set random postion of the spawner in a set range
        float x = Random.Range(10.0f, 18.0f) * ChoseSign();
        float z = (18.0f - Mathf.Abs(x)) * ChoseSign();
        Vector3 direction = new Vector3(x, Random.Range(0, 4.0f), z);
        this.gameObject.transform.position = direction;
    }

    void Update()
    {
        //if there is a ship in place, move to another random postion
        if (col.Equals (true))
        {
            col = false;
            float x = Random.Range(8.0f, 15.0f) * ChoseSign();
            float z = (15.0f - Mathf.Abs(x)) * ChoseSign();
            Vector3 direction = new Vector3(x, Random.Range(0, 10.0f), z);
            this.gameObject.transform.position = direction;
        }

        //spawn alien space-ship on current postion (if less than the max amout of ships)
        timer += Time.deltaTime;
        if (timer >= shipFrecuency && shipAmount<maxShipAmout )
        {
            Instantiate(myPrefabObject, this.gameObject.transform.position, Quaternion.identity);
            timer = 0;
            shipAmount++;  
        }
    }
    
    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.name == "PurpleAlienFighter(Clone)" )
        {
            col = true;
        }
    }

    void OnTriggerStay(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.name == "PurpleAlienFighter(Clone)")
        {
            col = true;
        }
    }

    //random sign -/ +
    float ChoseSign()
    {
        float num= Random.Range(0.0f, 1.0f);
        if (num > 0.5)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    public void DeletedShip()
    {
        shipAmount--;
    } 

}

