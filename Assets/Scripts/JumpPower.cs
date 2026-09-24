using UnityEngine;

public class JumpPower : MonoBehaviour {
    public float jumpForce = 6f;
    Rigidbody rb;
    bool onGround = true;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && onGround) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }

    void OnCollisionEnter(Collision collision) {
        onGround = true;
    }
}
