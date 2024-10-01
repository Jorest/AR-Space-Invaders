using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DelayARStart : MonoBehaviour
{
    private ARSession arSession;
    private ARCameraManager arCameraManager;

    void Awake()
    {
        arSession = FindObjectOfType<ARSession>();
        arCameraManager = FindObjectOfType<ARCameraManager>();
    }

    void Start()
    {
        StartCoroutine(StartARSessionWithDelay());
    }

    private IEnumerator StartARSessionWithDelay()
    {
        if (arSession != null && arSession.state == ARSessionState.None)
        {
            arSession.enabled = false;
            yield return new WaitForSeconds(0.5f); // Adjust the delay as necessary
            arSession.enabled = true;
        }

        // Ensure the AR Camera Background is enabled
        if (arCameraManager != null)
        {
            var arCameraBackground = arCameraManager.GetComponent<ARCameraBackground>();
            if (arCameraBackground != null)
            {
                arCameraBackground.enabled = true;
            }
        }

        // Wait until AR session is ready
        while (arSession.state < ARSessionState.Ready)
        {
            yield return null;
        }

        // Start the AR session
        arSession.Reset();
    }
}
