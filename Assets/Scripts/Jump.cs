using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    public Rigidbody rb;
    public float jumpAmount = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
        }
    }
}
