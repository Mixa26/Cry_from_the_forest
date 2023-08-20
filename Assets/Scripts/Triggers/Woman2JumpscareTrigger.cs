using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woman2JumpscareTrigger : MonoBehaviour
{
    public GameObject woman;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            woman.SetActive(true);
            woman.GetComponent<AudioSource>().Play();
            woman.GetComponent<Animator>().Play("Woman2FlyIn");
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
