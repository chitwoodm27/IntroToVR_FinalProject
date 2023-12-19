using UnityEngine;

public class DoorKnobCollision : MonoBehaviour
{
    // Reference to the cube GameObject



    public Transform doorTransform;
    public bool hand;



    void OnTriggerEnter(Collider other)
    {
        {

            if (other.CompareTag("Hand"))

            {
                hand = true;

            }

        }
    }
}