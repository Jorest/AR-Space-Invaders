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
    GameObject hud;
    PostProcessVolume volume;
    public AudioSource rocketHit;
    // Start is called before the first frame update
    void Start()
    {
        //help us check where the rockets hit
        Input.gyro.enabled = true;
        hud = GameObject.Find("Game Hud");
        //voluma carama effects when the game is over
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
            //calculate position of where the rocket hit (considering cam rotation)
            float angle = 0.0174533f * this.transform.eulerAngles.y; //to randians

            float x = collision.gameObject.transform.position.x;
            float z = collision.gameObject.transform.position.z;

            float nx = x * Mathf.Cos(angle) - z * Mathf.Sin(angle);
            float nz = z * Mathf.Cos(angle) + x * Mathf.Sin(angle);

            if (Mathf.Abs(nx)>= Mathf.Abs(nz))
            {
                if (nx >= 0)
                {
                    StartCoroutine( hud.GetComponent<HitAnimations>().HitR());
                }
                else
                {
                    StartCoroutine(hud.GetComponent<HitAnimations>().HitL());
                }

            }
            else
            {
                if (nz >= 0)
                {
                    StartCoroutine(hud.GetComponent<HitAnimations>().HitF());
                }
                else
                {
                    StartCoroutine(hud.GetComponent<HitAnimations>().HitB());
                }
            }
            Destroy(collision.gameObject);

            life--;
            if (life >= 0)
            {
                Destroy(hearts[(life)]);
                rocketHit.Play();
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
