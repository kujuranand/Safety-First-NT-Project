﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColor : MonoBehaviour
{
    public Color wantedColor;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButtonColor()
    {
        ColorBlock cb = button.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        button.colors = cb;
    }
}
