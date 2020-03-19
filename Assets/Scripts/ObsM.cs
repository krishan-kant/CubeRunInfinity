using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsM : MonoBehaviour
{
    public Rigidbody rb;
    public float Daccl = 2000f;
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -1 * Daccl * Time.deltaTime);
    }
}
