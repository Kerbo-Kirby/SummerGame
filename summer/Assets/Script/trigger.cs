using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject tirgg;


    private Color blue;
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        Destroy(tirgg);
        Debug.Log(("here we go boys"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
