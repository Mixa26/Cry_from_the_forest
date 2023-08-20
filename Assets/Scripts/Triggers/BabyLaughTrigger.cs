using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyLaughTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
