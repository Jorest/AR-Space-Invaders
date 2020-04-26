using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienExplotes : MonoBehaviour
{

    public GameObject explotion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.name == "bullet" || col.name == "bullet(Clone)")
        {

            GameObject.Find("Player").GetComponent<PLayerSrcript>().OneUp();
            GameObject.Find("SpaceShip Spawner").GetComponent<SpawnSpaceShips>().DeletedShip();
            Instantiate(explotion, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(col.gameObject);

        }

    }

}
