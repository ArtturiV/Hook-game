using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{

    bool turned = false;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") && !turned)
        {
            transform.Rotate(Vector3.down * -180);
            turned = true;

        }

        if (Input.GetKey("d") && turned)
        {
            transform.Rotate(Vector3.down * -180);
            turned = false;

        }
    }
}
