using UnityEngine;

public class Counter : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D collision) {
    if (collision.gameObject.CompareTag("Player")) {
        Scoreboard.instance.UpdateScore();
    }
}
}
