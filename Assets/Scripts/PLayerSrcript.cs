using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PLayerSrcript : MonoBehaviour
{
    private int life = 4;
    int points=0;
    public GameObject[] hearts;
    public GameObject GOCanvas;
    public Text pointText;
    public GameObject spawner;
    public Text finalScore;
    PostProcessVolume volume;
    // Start is called before the first frame update
    void Start()
    {
        //voluma carama effects 
        volume = this.transform.parent.gameObject.GetComponent<PostProcessVolume>();
    }

    void Update()
    {
        //update score count
        pointText.text = points.ToString();
        finalScore.text = points.ToString();
    }

    void OnTriggerEnter(Collider collision)
    {
        //each time a projectile hits the player he/she loses one heart

        if (collision.gameObject.name == "BioTorpedo Variant(Clone)")
        {
            Destroy(collision.gameObject);
            life--;
            if (life >= 0)
            {
                Destroy(hearts[(life)]);
            }
            //if no there is no life left you lose the game
            if (life ==0){
                GameOver();
            }
           
 
        }
    }
    void GameOver()
    {
        Debug.Log("GAME OVER");
        volume.enabled = true;
        GOCanvas.SetActive(true);
        spawner.SetActive(false);
        GameObject.Find("shoot Button").SetActive(false);

    }
   
   public void OneUp()
    {
        points++;
    }
}
