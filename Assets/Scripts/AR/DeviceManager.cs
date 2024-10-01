using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DeviceManager : MonoBehaviour
{
    [SerializeField] ARSession m_Session;

    private void Start()
    {
        StartCoroutine(StartSession());
    }


    private IEnumerator StartSession()
    {
        if ((ARSession.state == ARSessionState.None) ||
          (ARSession.state == ARSessionState.CheckingAvailability))
        {
            yield return ARSession.CheckAvailability();
        }

        if (ARSession.state == ARSessionState.Unsupported)
        {
            // Start some fallback experience for unsupported devices
        }
        else
        {
            // Start the AR session
            m_Session.enabled = true;
        }

        Debug.LogWarning(ARSession.state);
    }


}
