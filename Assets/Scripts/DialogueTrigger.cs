using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DialogueTrigger : MonoBehaviour
{
    public BlockReference blockRef;

    public bool mousePressed;

    public bool inArea;

    public bool blockExecuted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0) && blockExecuted == false)
        {
            blockRef.Execute();
            blockExecuted = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        blockExecuted = false;
    }

    // Update is called once per frame
    /*void Update()
    {
        *//*if (Input.GetMouseButtonDown(0))
        {
            mousePressed = true;
        } else
        {
            mousePressed = false;
        }*//*

        if(inArea == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                blockRef.Execute();
                blockExecuted = true;
            }
        }
           
    }

    void OnTriggerEnter(Collider other)
    {
        *//*if (mousePressed)
        {
            blockRef.Execute();
        }*//*
        if(blockExecuted == false)
        {
            inArea = true;
        } else if (blockExecuted == true)
        {
            inArea = false;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        inArea = false;
        blockExecuted = false;
    }*/
}
