using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour
{
    public int scNum;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scNum);
    }
}
