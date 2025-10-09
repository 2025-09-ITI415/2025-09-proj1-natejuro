using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepipe : MonoBehaviour
{
    private float speed = 6f;

    private void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }       
}
