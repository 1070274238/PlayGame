﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward* Input.GetAxis("Vertical") * Time.deltaTime * 5,Space.Self);
        transform.Rotate(transform.up * Input.GetAxis("Horizontal") , Space.Self);
    }
}
