using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeJumpscareTrigger : MonoBehaviour
{
    public GameObject tree;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            tree.GetComponent<AudioSource>().Play();
            tree.GetComponent<Animator>().Play("TreeDrop");
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
