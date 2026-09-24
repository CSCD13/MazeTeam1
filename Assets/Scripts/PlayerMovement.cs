using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 10f;

    void Update() {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}