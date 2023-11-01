using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionIntensityController : MonoBehaviour
{

    public Material materialToAdjust;
    float maxDistance = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        float emissionIntensity = Mathf.Lerp(0.0f, 10.0f, distance / maxDistance);
        materialToAdjust.SetColor("_EmissionColor", new Color(emissionIntensity, emissionIntensity, emissionIntensity));
    }
}
