using UnityEngine;

public class KeyOpen : MonoBehaviour
{
    public Transform doorTransform;


void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            {
                doorTransform.rotation = Quaternion.Euler(-90f, 90f, 0f);
            }
        }
    }
}

