using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestarScene()
    {
        Debug.Log("Restarting Game");
        SceneManager.LoadScene("ARInvadersScene");
    }
}
