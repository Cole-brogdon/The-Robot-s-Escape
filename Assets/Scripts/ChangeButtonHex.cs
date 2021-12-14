using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButtonHex : MonoBehaviour
{
    public Material off;
    public Material on;
    bool active = true;
    bool close = false;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (active && close)
            {
                this.GetComponent<SpriteRenderer>().material = off;
                door.SetActive(false);
                active = false;
                gameObject.GetComponent<AudioSource>().Play();
            }
            else if (close)
            {
                this.GetComponent<SpriteRenderer>().material = on;
                door.SetActive(true);
                active = true;
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