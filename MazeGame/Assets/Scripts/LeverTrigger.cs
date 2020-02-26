using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    //1 for z-axis 0 for x-axis
    public int dirct;
    void OnTriggerEnter(Collider other)
    {
        if (dirct == 1)
        {
            if (other.gameObject.CompareTag("1Step(EC)"))
            {
                CharacterMov.numbX1 = 0.1f;
            }

            if (other.gameObject.CompareTag("0Step(EC)"))
            {
                CharacterMov.numbX1 = 0;
            }

            if (other.gameObject.CompareTag("-1Step(EC)"))
            {
                CharacterMov.numbX1 = -0.1f;
            }
            
            if (other.gameObject.CompareTag("1/2Step"))
            {
                CharacterMov.numbX1 = 0.05f;
            }

            if (other.gameObject.CompareTag("-1/2Step"))
            {
                CharacterMov.numbX1 = -0.05f;
            }
        }

        if (dirct == 0)
        {
            if (other.gameObject.CompareTag("1Step(EC)"))
            {
                CharacterMov.numbZ1 = 0.1f;
            }

            if (other.gameObject.CompareTag("0Step(EC)"))
            {
                CharacterMov.numbZ1 = 0;
            }

            if (other.gameObject.CompareTag("-1Step(EC)"))
            {
                CharacterMov.numbZ1 = -0.1f;
            }
            
            if (other.gameObject.CompareTag("1/2Step"))
            {
                CharacterMov.numbZ1 = 0.05f;
            }

            if (other.gameObject.CompareTag("-1/2Step"))
            {
                CharacterMov.numbZ1 = -0.05f;
            }
        }
    }
}
