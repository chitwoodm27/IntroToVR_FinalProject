using UnityEngine;

public class CylinderCollision : MonoBehaviour
{

    public bool cylindervalue;



    void OnTriggerEnter(Collider other)
    {
        {

            if (other.CompareTag("Cylinder"))

            {

                cylindervalue = true;

            }

        }
    }
}

