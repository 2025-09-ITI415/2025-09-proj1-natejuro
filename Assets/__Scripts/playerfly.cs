using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfly : MonoBehaviour {

    private float moveSpeed = 6f;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.linearVelocity = Vector2.up * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        manager.instance.GameOver();
    }
}