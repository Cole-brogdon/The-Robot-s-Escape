using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    private AudioSource msource;
    private GameObject[] other;
    private bool NotFirst = false;
    private void Awake()
    {
        other = GameObject.FindGameObjectsWithTag("Music");

        foreach (GameObject o in other)
        {
            if (o.scene.buildIndex==-1)
            {
                NotFirst = true;
            }
            
        }

        if(NotFirst==true)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        msource.Play();
    }

    public void PlayMusic()
    {
        if(msource.isPlaying)
        {
            return;
        }
        msource.Play();
    }

    public void StopMusic()
    {
        msource.Stop();
    }
    
}
