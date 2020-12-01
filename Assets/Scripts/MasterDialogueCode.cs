using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MasterDialogueCode : MonoBehaviour
{
    /*public bool pause = false;*/

    public Flowchart allVarFlowchart;

    public BlockReference blockRef1;
    bool block1Executed;

    public BlockReference blockRef2;
    bool block2Executed;

    public BlockReference blockRef3;
    bool block3Executed;

    public BlockReference blockRef4;
    bool block4Executed;

    public BlockReference blockRef4_25;

    public BlockReference blockRef4_5;
    bool blockCrewmateExecuted;

    public BlockReference blockRef4_5_5;

    public BlockReference blockRef4_75;
    bool blockDoneShipExecuted;

    public BlockReference blockRef5_0;

    public BlockReference blockRef5;
    bool block5Executed;
    bool haveSeashell;
    private GameObject shell;

    public BlockReference blockRef6;

    bool inOptionDia;


    // Start is called before the first frame update
    void Start()
    {
        shell = GameObject.FindGameObjectWithTag("Shell");
    }

    // Update is called once per frame
    void Update()
    {
        block1Executed = allVarFlowchart.GetBooleanVariable("done1");
        block2Executed = allVarFlowchart.GetBooleanVariable("done2");
        block3Executed = allVarFlowchart.GetBooleanVariable("done3");
        block4Executed = allVarFlowchart.GetBooleanVariable("done4");
        blockCrewmateExecuted = allVarFlowchart.GetBooleanVariable("doneCrew");
        blockDoneShipExecuted = allVarFlowchart.GetBooleanVariable("doneShip");
        haveSeashell = allVarFlowchart.GetBooleanVariable("haveShell");
        block5Executed = allVarFlowchart.GetBooleanVariable("done5");
        inOptionDia = allVarFlowchart.GetBooleanVariable("inOptionDia");

        if (haveSeashell == true)
        {
            Object.Destroy(shell);
        }
    }
    private void OnTriggerStay(Collider other) //later: fool / dif one for crewmate, dif one for seashell
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (other.tag == "Fool" && inOptionDia == false)
            {
                if (block1Executed == false)
                {
                    blockRef1.Execute();

                }
                else if (haveSeashell == true && block5Executed == false)
                {
                    //seashell storyline
                    blockRef5.Execute();

                }
                else if (block2Executed == false)
                {
                    blockRef2.Execute();

                }
                else if (block3Executed == false)
                {
                    blockRef3.Execute();

                }
                else if (block4Executed == false)
                {
                    blockRef4.Execute();

                }
                else if (blockCrewmateExecuted == false)
                {
                    blockRef4_25.Execute();
                }
                else if (blockDoneShipExecuted == false)
                {
                    blockRef4_75.Execute();

                }
                else
                {
                    blockRef6.Execute();
                }



            }
            if (other.tag == "Crew")
            {
                if (Input.GetMouseButtonDown(0) && blockCrewmateExecuted == false)
                {
                    blockRef4_5.Execute();

                }
                else if (blockCrewmateExecuted == true)
                {
                    blockRef4_5_5.Execute();
                }
            }
            if (other.tag == "Shell" && haveSeashell == false && inOptionDia == false)
            {
                blockRef5_0.Execute();
            }
        } // mouse clicked end 

    }

}


