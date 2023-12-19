using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOpen : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform doorTransform;


    void Start()
    {
        {
            CubeCollision cubeCollision = GetComponent<CubeCollision>();
            bool cubevalue = cubeCollision.cubevalue;

            TorusCollision torusCollision = GetComponent<TorusCollision>();
            bool torusvalue = torusCollision.torusvalue;

            CylinderCollision cylinderCollision = GetComponent<CylinderCollision>();
            bool cylindervalue = cylinderCollision.cylindervalue;

            if (cubevalue == true && torusvalue == true && cylindervalue == true)
            {
                doorTransform.rotation = Quaternion.Euler(-90f, 90f, 0f);

            }
        }
    }
}