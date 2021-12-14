using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBlocks : MonoBehaviour
{   
    bool close = false;
    public GameObject blocks;
    private Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = blocks.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (close)
            {
                blocks.transform.position = initialPos;
                gameObject.GetComponent<AudioSource>().Play();
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        close = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        close = false;
    }
}
