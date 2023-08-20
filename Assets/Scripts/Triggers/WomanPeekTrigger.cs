using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanPeekTrigger : MonoBehaviour
{
    public GameObject woman;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            GetComponent<AudioSource>().Play();
            woman.GetComponent<Animator>().Play("WomanPeek");
            Invoke("Deactivate", 1.0f);
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    private void Deactivate()
    {
        woman.SetActive(false);
    }
}
