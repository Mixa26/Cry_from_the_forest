using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpsterJumpscareTrigger : MonoBehaviour
{
    public GameObject girl;
    public Transform orientation;
    public GameObject dontCheckDumpster;

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            dontCheckDumpster.SetActive(true);
            girl.SetActive(true);
            girl.GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
            triggered = true;
        }
    }

    private void Update()
    {
        if (triggered && ((orientation.transform.rotation.y >= -0.99f && orientation.transform.rotation.y <= -0.70f) || (orientation.transform.rotation.y <= 0.99f && orientation.transform.rotation.y >= 0.70f)))
        {   
            girl.GetComponent<Animator>().Play("HideGirl");
            triggered = false;
        }
    }
}
