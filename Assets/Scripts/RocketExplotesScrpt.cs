using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketExplotesScrpt : MonoBehaviour
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
            Instantiate(explotion, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        if (col.name == "PlasmaExplosionEffect" || col.name == "PlasmaExplosionEffect(Clone)") 
        {
            Destroy(this.gameObject);
        }

    }

}
