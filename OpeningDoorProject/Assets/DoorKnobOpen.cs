using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnobOpen : MonoBehaviour
{
    public Transform doorTransform;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            {
                doorTransform.rotation = Quaternion.Euler(-90f, 90f, 0f);
            }
        }
    }
}
