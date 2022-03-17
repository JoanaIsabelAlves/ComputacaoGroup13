using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformation : MonoBehaviour
{

    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(5, -1, 0);
        transform.Rotate(0, 90, 0);
        
    }
   

    // Update is called once per frame
    void Update()
    {
       
    }
}
