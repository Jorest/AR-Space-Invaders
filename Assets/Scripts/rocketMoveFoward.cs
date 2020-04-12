using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMoveFoward : MonoBehaviour
{
    public GameObject waypoint;
    public float speed;
    public GameObject rocket;
    void Start()
    {
        rocket.transform.Rotate(0f, 180f, 0f);
    }

    // make the rocket move towards the player position
    void Update()
    {
     
        //rotation
        Vector3 direction = waypoint.transform.position - rocket.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        rocket.transform.rotation = Quaternion.Lerp(rocket.transform.rotation, rotation, 2f * Time.deltaTime);
        // move rocket to us
        rocket.transform.position = Vector3.MoveTowards(rocket.transform.position, waypoint.transform.position, Time.deltaTime * speed);

    }


}
