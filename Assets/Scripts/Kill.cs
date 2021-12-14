using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    private AudioSource msource;
    private GameObject[] other;
    private bool NotFirst = false;
    private void Update()
    {
        other = GameObject.FindGameObjectsWithTag("Music");

        foreach (GameObject o in other)
        {
            Destroy(o);
        }
    }
}
