using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createpipe : MonoBehaviour {

private float time = 1f;
private float height = .5f;
public GameObject pipe;
private float count = 0f;

private void Start() {
    Spawn();
 }

 private void Update() {
    count += Time.deltaTime;
    if (count > time) {
        Spawn();
        count = 0f;
    }
 
 }

private void Spawn() {
    Vector3 spawnPos = transform.position + new Vector3(0f, Random.Range(-height, height));
    GameObject spawnedPipe = Instantiate<GameObject>(pipe);

    Destroy(pipe, 10f);
}
}