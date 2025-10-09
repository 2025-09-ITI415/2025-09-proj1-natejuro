using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfly : MonoBehaviour {

    private float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);
            // rb.linearVelocity = Vector2.up * moveSpeed;
        }
    }
}