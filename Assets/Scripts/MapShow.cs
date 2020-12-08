using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class MapShow : MonoBehaviour
{
    public Flowchart allVarFlowchart;
    bool haveMap;
    public GameObject map;
    public GameObject mapButton;
    public bool viewMap = false; 

    // Start is called before the first frame update
    void Start()
    {
        mapButton.SetActive(false);
    }

    // Update is called once per frame
     void Update()
    {
        haveMap = allVarFlowchart.GetBooleanVariable("haveMap");

        if(haveMap == true)
        {
            mapButton.SetActive(true);

            if (Input.GetKeyUp("m"))
            {
                DoMap();
            }

            if (viewMap == true)
            {
                map.SetActive(true);
            }
            else if (viewMap == false)
            {
                map.SetActive(false);
            }
        }
        
    }

    public void DoMap()
    {
         viewMap = !viewMap;

    }
}
