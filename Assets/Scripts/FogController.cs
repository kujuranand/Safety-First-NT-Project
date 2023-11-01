using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class FogController : MonoBehaviour
{

    FogMode fogMode;


    // Start is called before the first frame update
    void Start()
    {
        fogMode = RenderSettings.fogMode;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleFog() 
    {
        if (RenderSettings.fog) 
            {
                RenderSettings.fog = false;
            } 
        else 
        {
            RenderSettings.fog = true;
            RenderSettings.fogMode = fogMode;
        }
    }

}
