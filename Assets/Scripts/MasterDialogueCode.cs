using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MasterDialogueCode : MonoBehaviour
{
    /*public bool pause = false;*/

    public BlockReference blockRef1;
    public bool block1Executed = false;

    public BlockReference blockRef2;
    public bool block2Executed = false;

    public BlockReference blockRef3;
    public bool block3Executed = false;

    public BlockReference blockRef4;
    public bool block4Executed = false;

    public BlockReference blockRef4_25;

    public BlockReference blockRef4_5;
    public bool blockCrewmateExecuted = false;

    public BlockReference blockRef4_5_5;

    public BlockReference blockRef4_75;
    public bool blockDoneShipExecuted = false;

    public BlockReference blockRef5_0;

    public BlockReference blockRef5;
    public bool block5Executed = false;
    public bool haveSeashell = false;

    public BlockReference blockRef6;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other) //later: fool / dif one for crewmate, dif one for seashell
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (block1Executed == false)
            {
                blockRef1.Execute();
                block1Executed = true;
            }
            else if (block2Executed == false)
            {
                blockRef2.Execute();
                block2Executed = true;
            }
            else if (block3Executed == false)
            {
                blockRef3.Execute();
                block3Executed = true;
            }
            else if (block4Executed == false)
            {
                blockRef4.Execute();
                block4Executed = true;
            }
            else if (blockCrewmateExecuted == false)
            {
                blockRef4_25.Execute();
            }
            else if (blockDoneShipExecuted == false)
            {
                blockRef4_75.Execute();
                blockDoneShipExecuted = true;
            }
            else
            {
                blockRef6.Execute();
            }

            //seashell storyline
            if (haveSeashell == true && block5Executed == false)
            {
                blockRef5.Execute();
                block5Executed = true;
            }
        }

    }

    //crewmate dialogue
    /*private void OnTriggerStay(Collider other) //crewmate
    {
        if (Input.GetMouseButtonDown(0) && blockCrewmateExecuted == false)
        {
            blockRef4_5.Execute();
            blockCrewmateExecuted = true;
        } else
        {
            blockRef4_5_5.Execute();
        }

    }*/

    //seashell pick up dialogue
    /*private void OnTriggerEnter(Collider other) //seashell
    {
        if (haveSeashell == false)
        {
            blockRef5_0.Execute();
        }
    }*/
}

    
