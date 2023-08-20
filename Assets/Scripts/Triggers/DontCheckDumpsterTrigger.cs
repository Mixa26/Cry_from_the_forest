using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontCheckDumpsterTrigger : MonoBehaviour
{
    public GameObject girl;

    private void OnTriggerEnter(Collider other)
    {
        girl.SetActive(true);
        girl.GetComponent<AudioSource>().Play();
        Invoke("Deactivate", 0.5f);
        GetComponent<BoxCollider>().enabled = false;
    }

    private void Deactivate()
    {
        girl.SetActive(false);
    }

}
