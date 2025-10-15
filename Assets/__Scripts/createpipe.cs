using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createpipe : MonoBehaviour {

private float time = 1.5f;
private float height = 2f;
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
    Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-height, height));
    GameObject spawnedPipe = Instantiate(pipe, spawnPos, Quaternion.identity);

    Destroy(spawnedPipe, 10f);
}
}