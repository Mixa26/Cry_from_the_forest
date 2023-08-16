using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerJumpscareTrigger : MonoBehaviour
{
    public GameObject deer;
    public AudioSource deerAudioSource;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
        deerAudioSource.Play();
        deer.GetComponent<Animator>().Play("Run");
        GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {
        
    }
}
