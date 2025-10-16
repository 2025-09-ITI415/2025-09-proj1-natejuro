using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfly : MonoBehaviour {

    private float moveSpeed = 8f;
    private float tiltForce = 4f;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.linearVelocity = Vector2.up * moveSpeed;
        }
    }

    private void FixedUpdate() {
        if (rb.linearVelocity.y < 0) {
            float tiltAngle = rb.linearVelocity.y*tiltForce;
            transform.rotation = Quaternion.Euler(0, 0, tiltAngle);
        }
        else if (rb.linearVelocity.y > 0) {
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0, 0, 0), Time.deltaTime*tiltForce);
                }
        else {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

    private void OnCollisionEnter2D(Collision2D collision) {
        manager.instance.GameOver();
    }
}