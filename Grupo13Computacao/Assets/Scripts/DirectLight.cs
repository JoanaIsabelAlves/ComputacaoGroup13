using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectLight : MonoBehaviour
{
    // Start is called before the first frame update

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.eulerAngles.x < 180)
        {
            transform.Rotate(0.1f, 0, 0);
        }

        Color.Lerp(Color.yellow, Color.white, float t);
        

       /* if(transform.eulerAngles.x < 75)
        {
            lt.color = (Color.yellow );
        }
        else if(transform.eulerAngles.x < 145  && transform.eulerAngles.x > 75)
        {
            lt.color = (Color.white );
        }
        else if(transform.eulerAngles.x > 145)
        {
            lt.color = (Color.red );
        } */         
        
    }
}
