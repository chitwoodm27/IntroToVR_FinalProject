using UnityEngine;

public class PlatformCollision : MonoBehaviour
{

    public Transform doorTransform;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            {
                doorTransform.rotation = Quaternion.Euler(-90f, 0f, 0f);
            }
        }
    }
}
