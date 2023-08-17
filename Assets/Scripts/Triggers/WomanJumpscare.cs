using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanJumpscare : MonoBehaviour
{
    public GameObject horrorWoman;
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            horrorWoman.SetActive(true);
            horrorWoman.GetComponent<AudioSource>().Play();
            horrorWoman.GetComponent<Animator>().Play("Woman_close");
            door.GetComponent<Animator>().Play("SlamReverse");
            door.GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
