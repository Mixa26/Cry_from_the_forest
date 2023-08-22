using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedGasTrigger : MonoBehaviour
{
    public GameObject needGasText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            needGasText.SetActive(true);            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            needGasText.SetActive(false);
        }
    }
}
