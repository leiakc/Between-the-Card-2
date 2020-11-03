using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DialogueTrigger : MonoBehaviour
{
    public BlockReference blockRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        blockRef.Execute();
    }
}
