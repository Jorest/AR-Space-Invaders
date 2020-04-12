using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamara : MonoBehaviour
{
    public GameObject camara;
    public GameObject spaceShip;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = camara.transform.position - spaceShip.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        spaceShip.transform.rotation = Quaternion.Lerp(spaceShip.transform.rotation, rotation, 360f );

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
