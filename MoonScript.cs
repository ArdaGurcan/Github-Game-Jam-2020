using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour
{
    [SerializeField]
    static float G = 6f;
    public Rigidbody2D playerHead;
    public Rigidbody2D playerTail;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gravity = -Vector3.Normalize(playerHead.transform.position - transform.position) * Mathf.Pow(transform.localScale.x, 2) * G * Mathf.Pow(Vector3.Distance(transform.position, playerHead.transform.position), -3);
        playerHead.AddForce(gravity, ForceMode2D.Force);
        playerTail.AddForce(gravity, ForceMode2D.Force);
    }
}
