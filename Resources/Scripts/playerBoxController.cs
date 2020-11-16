﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBoxController : MonoBehaviour
{
    bool highlighted = false;
    Color currentColor;

    private void Start()
    {
        currentColor = GetComponent<SpriteRenderer>().color;
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        highlighted = !highlighted;

        Debug.Log(highlighted);

        if(highlighted)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }else
        {
            GetComponent<SpriteRenderer>().color = currentColor;
        }
    }
}