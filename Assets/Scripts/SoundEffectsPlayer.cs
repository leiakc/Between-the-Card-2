using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    private Animator anim;
    public bool isWalk = false;
    public GameObject walkingSFX;

    public SFXbackground secondScript;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        walkingSFX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isWalk = anim.GetBool("isMoving");

        if(isWalk == true)
        {
            walkingSFX.SetActive(true);

            if (secondScript.onWood == true)
            {      
                walkingSFX.SetActive(false);
            }
           
        } else
        {
            walkingSFX.SetActive(false);
        }
    }
    /* private void OnTriggerStay(Collider other)
     {
         if (other.tag == "wood")
         {
             onWood = true;
         }

     }*/

  /*  private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wood")
        {
            onWood = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "wood")
        {
            onWood = false;
        }
    }*/
}