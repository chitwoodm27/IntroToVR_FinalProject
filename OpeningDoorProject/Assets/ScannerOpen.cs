using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScannerOpen : MonoBehaviour
{
    public Transform doorTransform;
    public Material GreenLight;
    public GameObject LightIndicator;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Card"))
        {
            {
                LightIndicator.GetComponent<Renderer>().material = GreenLight;
                doorTransform.rotation = Quaternion.Euler(-90f, 90f, 0f);
            }
        }
    }
}
