using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPart : MonoBehaviour
{
    public GameObject body;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = body.transform.rotation;
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * 0.08f, ForceMode2D.Impulse);
        }
    }
}
