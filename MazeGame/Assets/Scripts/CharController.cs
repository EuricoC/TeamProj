using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public bool hasKey = false;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "KeyPickup(RB)")
        {
            Destroy(collider.gameObject);
            hasKey = true;
        }
    }
}