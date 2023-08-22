using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveOffTrigger : MonoBehaviour
{
    public GameObject driveOffText;
    public GameObject gameEnd;

    private bool inCollider = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = true;
            driveOffText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = false;
            driveOffText.SetActive(false);
        }
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.E))
        {
            driveOffText.SetActive(false);
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
            gameEnd.SetActive(true);
            gameEnd.GetComponent<Animator>().Play("GameEnd");
        }
    }
}
