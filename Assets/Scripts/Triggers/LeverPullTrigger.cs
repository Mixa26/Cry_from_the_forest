using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPullTrigger : MonoBehaviour
{
    public GameObject lever;
    public GameObject churchGate;
    public GameObject leverText;
    public GameObject mask_jumpscare;
    public Transform orientation;

    private bool inCollider = false;
    private bool alreadyPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = true;
            leverText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = false;
            leverText.SetActive(false);
        }
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.E) && !alreadyPressed)
        {
            alreadyPressed = true;
            mask_jumpscare.SetActive(true);
            leverText.SetActive(false);
            lever.GetComponent<Animator>().Play("PullLever");
            lever.GetComponent<AudioSource>().Play();
            churchGate.GetComponent<Animator>().Play("GateOpen");
            churchGate.GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
            inCollider = false;
        }

        if (alreadyPressed && (orientation.transform.rotation.y >= -0.96f && orientation.transform.rotation.y >= 0.96f))
        {
            mask_jumpscare.GetComponent<AudioSource>().Play();
            mask_jumpscare.GetComponent<Animator>().Play("GoBellowFloor");
            enabled = false;
        }
        
    }

}

