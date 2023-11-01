using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderEmissionColorCamera : MonoBehaviour
{

    public Camera cam;
    float maxDistance = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(cam.transform.position, transform.position);
        //float emission = Mathf.Clamp01(1 - distance / maxDistance);
        float emission = Mathf.Lerp(0.0f, 10.0f, distance / maxDistance);
        Color color = new Color(emission, 0, 0);
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        mat.SetColor("_EmissionColor", color * emission);
        mat.EnableKeyword("_EMISSION");
        // In the Unity Editor:
        // Set the material rendering mode to "Standard" or "Standard (Specular setup)"
        // Set the emission color to a low value (e.g. 0.1,0.1,0.1)
        // Enable the "Emission" checkbox under "Material"
        // Enable the "Emission" checkbox under "Lighting"

    }
}
