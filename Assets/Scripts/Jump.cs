using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    float force = 0f;
    [SerializeField]
    Rigidbody2D rb = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            rb.AddForce(new Vector2(0f, force));

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(10f, 0f));

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(-10f, 0f));

        }
    }
}
