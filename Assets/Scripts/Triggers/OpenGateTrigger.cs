using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateTrigger : MonoBehaviour
{
    public GameObject gateOpenText;

    public GameObject chain1;
    public GameObject chain2;
    public GameObject keyhole;
    public Animator gateAnimator;

    private bool inCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerCapsule")
        {
            gateOpenText.SetActive(true);
            inCollider = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gateOpenText.SetActive(false);
        inCollider = false;
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.E))
        {
            Destroy(gateOpenText);
            Destroy(chain1);
            Destroy(chain2);
            Destroy(keyhole);
            gateAnimator.Play("FenceOpen");
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
