﻿using System.Collections;
using UnityEngine;

public class StarController : MonoBehaviour
{
    private float rotspeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
      this.transform.Rotate (0, Random.Range (0, 360), 0);   
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotspeed, 0); 
    }
}
