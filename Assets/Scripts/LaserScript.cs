using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //destroy the enemies and count the points
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "PurpleAlienFighter(Clone)" || col.name== "BioTorpedo Variant(Clone)" || col.name == "PurpleAlienFighter")
        {
            if (col.name == "PurpleAlienFighter(Clone)" || col.name == "PurpleAlienFighter")
            {
                GameObject.Find("Player").GetComponent<PLayerSrcript>().OneUp();
                GameObject.Find("SpaceShip Spawner").GetComponent<SpawnSpaceShips>().DeletedShip();
                //col.gameObject.GetComponent<AlienExplotes>().Explote();
                // col.gameObject.transform.GetChild(0).gameObject.SetActive(true);

            }
            
           
            Destroy(col.gameObject);

           
        }
    }
}