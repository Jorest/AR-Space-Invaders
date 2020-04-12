using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shootRockets : MonoBehaviour
{
    public GameObject myPrefabObject = null;
    public GameObject SpaceShip;
    float timer;
    //how often the aliens shoot
    public float rocketFrec;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // creates a new instance of rocket every rocketFrec
        timer += Time.deltaTime;
        if (timer > rocketFrec)
        {
            timer = 0;
            Instantiate(myPrefabObject, SpaceShip.transform.position, Quaternion.identity);
            
           
        }
    }
}
