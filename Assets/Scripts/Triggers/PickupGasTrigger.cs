using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGasTrigger : MonoBehaviour
{
    public GameObject driveOffTrigger;
    public GameObject needGasTrigger;
    public GameObject pickupGasText;
    public GameObject gas;
    public GameObject horrorWoman;
    public Transform orientation;

    private bool inCollider = false;
    private bool activated = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = true;
            pickupGasText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = false;
            pickupGasText.SetActive(false);
        }
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.E))
        {
            activated = true;
            horrorWoman.SetActive(true);
            driveOffTrigger.SetActive(true);
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<AudioSource>().Play();
            pickupGasText.SetActive(false);
            gas.SetActive(false);
            needGasTrigger.GetComponent<BoxCollider>().enabled = false;
            inCollider = false;
        }
        
        if (activated && ((orientation.transform.rotation.y >= 0.30f && orientation.transform.rotation.y <= 0.70f) || (orientation.transform.rotation.y >= -0.70f && orientation.transform.rotation.y <= -0.30f)))
        {
            horrorWoman.GetComponent<AudioSource>().Play();
            horrorWoman.GetComponent<Animator>().Play("FlyOff");
            enabled = false;
        }

    }
}
