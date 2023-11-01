using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forklift_anim_STOP : MonoBehaviour
{
    
    public float animationDuration = 5.0f;
    

    void Start()
    {
        GetComponent<Animation>().Play("Forklift_anim");
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("StopAnimation", animationDuration);
    }

    // private void whenButtonClicked() 
    // {
        
    // }

    private void StopAnimation()
    {
        GetComponent<Animation>().Stop("Forklift_anim");
        Invoke("StartAnimation", animationDuration);
    }

    private void StartAnimation()
    {
        GetComponent<Animation>().Play("Forklift_anim");
    }

}
