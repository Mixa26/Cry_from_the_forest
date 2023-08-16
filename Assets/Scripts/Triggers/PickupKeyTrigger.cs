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
            keyPickupText.active = true;
            inCollider = true;
        }   
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "PlayerCapsule")
        {
            keyPickupText.active = false;
            inCollider = false;
        }
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.E))
        {
            keyPickupText.active = false;
            key.active = false;
            deer.active = true;
            deerJumpscareCollider.active = true;
            gateCollider.active = true;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
