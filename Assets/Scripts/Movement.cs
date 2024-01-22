using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal"); // Returns 1 when moving right and -1 when moving left
        Vector3 move = transform.right * input * speed * Time.deltaTime;
        rb.MovePosition(transform.position + move);
    }
}
