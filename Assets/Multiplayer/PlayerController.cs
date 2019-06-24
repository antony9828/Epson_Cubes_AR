﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
