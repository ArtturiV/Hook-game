using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float force = 0;
    float radsin;
    float radcos;
    public RopeSystem system;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        GameObject hepu = GameObject.Find("Heppu");
        system = hepu.GetComponent<RopeSystem>();
        radsin = Mathf.Sin(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        radcos = Mathf.Cos(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        rb.AddForce(new Vector2(radsin * -force, radcos * force));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        system.tormaa(collision.GetContact(0).point);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0f;
        rb.isKinematic = true;
    }

    }
