using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKeyTrigger : MonoBehaviour
{
    public GameObject keyPickupText;
    public GameObject key;
    public GameObject deer;
    public GameObject deerJumpscareCollider;
    public GameObject gateCollider;

    private bool inCollider = false;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "PlayerCapsule")
        {
            keyPickupText.SetActive(true);
            inCollider = true;
        }   
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "PlayerCapsule")
        {
            keyPickupText.SetActive(false);
            inCollider = false;
        }
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.E))
        {
            GetComponent<AudioSource>().Play();
            keyPickupText.SetActive(false);
            key.SetActive(false);
            deer.SetActive(true);
            deerJumpscareCollider.SetActive(true);
            gateCollider.SetActive(true);
            GetComponent<BoxCollider>().enabled = false;
            inCollider = false;
        }
    }
}
