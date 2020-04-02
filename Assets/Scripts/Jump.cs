using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    float force = 0f;
    [SerializeField]
    float lim = 0f;
    [SerializeField]
    float velo = 0f;
    [SerializeField]
    Rigidbody2D rb = null;
    float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < lim)
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(new Vector2(0f, force));
                counter++;
            }
        }

        if (Input.GetKeyUp("space"))
        {
            counter = lim;
        }
        
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-velo, rb.velocity.y);

        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(velo, rb.velocity.y);

        }

        if (Input.GetKeyUp("a"))
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        if (Input.GetKeyUp("d"))
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        counter = 0;
    }
}
