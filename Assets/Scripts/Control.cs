﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Physics.IgnoreCollision(other, GetComponent<Collider>());
        }
    }
}
