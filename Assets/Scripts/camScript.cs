using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camScript : MonoBehaviour
{
    public GameObject webCameraPlane;

    void Start()
    {
        //get camara component
        if (Application.isMobilePlatform)
        {
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right, 90);
        }
        //enebles gyro
        Input.gyro.enabled = true;

        //set resolution and render on the plane 
        WebCamTexture webCameraTexture = new WebCamTexture(1920, 1080, 30);
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();

    }

    void Update()
    {
        //update camara rotation
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation = cameraRotation;
    }


}
