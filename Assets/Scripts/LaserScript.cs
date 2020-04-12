using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public PLayerSrcript aja;
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
        if (col.name == "PurpleAlienFighter(Clone)" || col.name== "BioTorpedo Variant(Clone)")
        {
            if (col.name == "PurpleAlienFighter(Clone)")
            {
                GameObject.Find("Player").GetComponent<PLayerSrcript>().OneUp();
                GameObject.Find("SpaceShip Spawner").GetComponent<SpawnSpaceShips>().DeletedShipDeletedShip();
            }
            Destroy(col.gameObject);
        }
    }
}