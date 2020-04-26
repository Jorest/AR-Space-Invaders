using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScipt : MonoBehaviour
{
    float timer;
    public float explosionTime=1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > explosionTime)
        {
            Destroy(this.gameObject);
            
        }
    }
}
