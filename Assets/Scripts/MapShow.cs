using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapShow : MonoBehaviour
{

    public GameObject map;
    public bool viewMap = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {

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

    public void DoMap()
    {
         viewMap = !viewMap;

    }
}
