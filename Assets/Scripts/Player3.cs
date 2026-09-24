using UnityEngine;

public class Player3 : MonoBehaviour
{
    public float spinSpeed = 360f; 

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }
    }
}