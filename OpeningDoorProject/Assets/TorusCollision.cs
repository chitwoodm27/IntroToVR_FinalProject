using UnityEngine;

public class TorusCollision : MonoBehaviour
{


    public bool torusvalue;
    void OnTriggerEnter(Collider other)
    {
        {

            if (other.CompareTag("Torus"))

            {

                torusvalue = true;

            }

        }
    }
}

