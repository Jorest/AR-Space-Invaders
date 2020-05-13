using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAnimations : MonoBehaviour
{
    public GameObject HF;
    public GameObject HB;
    public GameObject HL;
    public GameObject HR;
    public float animTime = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator HitF()
    {
        HF.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        HF.SetActive(false);

    }
    public IEnumerator HitB()
    {
        HB.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        HB.SetActive(false);
    }
    public IEnumerator HitL()
    {
        HL.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        HL.SetActive(false);
    }
    public IEnumerator HitR()
    {
        HR.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        HR.SetActive(false);
    }


}
