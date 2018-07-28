using System.Collections;
using System.Collections.Generic;
using Sanford.Multimedia.Midi;
using UnityEngine;

public class noteBehaviour : MonoBehaviour {

    public int noteCode = 50;

    void OnTriggerEnter(Collider other)
    {
        if (transform.tag == "validNote")
        {
            Destroy(transform.gameObject);

            GameObject.FindGameObjectWithTag("soundPlayer").GetComponent<playNote>().playChord(noteCode);

        }
        else if (transform.tag == "invalidNote")
        {
            Debug.Log("Invalid Note!");
        }
    }
}
