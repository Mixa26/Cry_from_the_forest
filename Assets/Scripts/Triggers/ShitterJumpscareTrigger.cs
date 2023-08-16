using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitterJumpscareTrigger : MonoBehaviour
{
    public GameObject shitter;
    public GameObject horrorGirl;
    public GameObject horrorRunning;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            shitter.GetComponent<Animator>().Play("DoorSlam");
            shitter.GetComponent<AudioSource>().Play();
            horrorGirl.GetComponent<Animator>().Play("HorrorGirlRun");
            horrorRunning.GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
