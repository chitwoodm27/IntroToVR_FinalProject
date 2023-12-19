using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public Transform doorTransform;


    public bool cubevalue;

    void OnTriggerEnter(Collider other)
    {
        {


            if (other.CompareTag("Cube"))

            {
                doorTransform.rotation = Quaternion.Euler(-90f, 0f, 0f);

                cubevalue = true;

            }

        }
    }
}

