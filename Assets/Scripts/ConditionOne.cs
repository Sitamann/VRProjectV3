using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionOne : MonoBehaviour
{
    public bool yes= false;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Swish"))
        {
            yes = true;
            DoorOpening.instance.Open();
        }
    }
}
