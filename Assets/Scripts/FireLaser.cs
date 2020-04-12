using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireLaser : MonoBehaviour
{

    public Button fireButton;
    public AudioSource laserSound;
    // Start is called before the first frame update
    void Start()
    {
        //button listener
        fireButton.onClick.AddListener(OnButtonDown);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //fiers the laser
    void OnButtonDown()
    {
        laserSound.Play();

        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        bullet.transform.rotation = this.transform.rotation;
        bullet.transform.position = this.transform.position;
        rb.AddForce(this.transform.forward * 1200f);
        Destroy(bullet, 3);


    }
}
