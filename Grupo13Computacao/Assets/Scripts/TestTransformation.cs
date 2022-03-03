using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.localScale);
        Debug.Log(transform.localEulerAngles);
        Debug.Log(transform.localPosition);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
