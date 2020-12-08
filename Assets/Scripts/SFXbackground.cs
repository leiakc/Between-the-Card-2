using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXbackground : MonoBehaviour
{

    public bool onWood = false;
    public GameObject woodSFX;
    public GameObject seaSFX;
    public SoundEffectsPlayer secondScript;

    // Start is called before the first frame update
    void Start()
    {
        woodSFX.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (onWood == true && secondScript.isWalk == true)
        {
            woodSFX.SetActive(true);
        }
        else
        {
            woodSFX.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "wood")
        {
            onWood = true;
        }

        if (other.tag == "notSeaSound")
        {
            seaSFX.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "wood")
        {
            onWood = false;
        }

        if(other.tag == "notSeaSound")
        {
            seaSFX.SetActive(true);
        }
    }
}
