using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private Vector3 targetScale = new Vector3(2f, 2f, 2f);
    private bool isScaled = false;

    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            isScaled = !isScaled;
            transform.localScale = isScaled ? targetScale : new Vector3(1f,1f,1f);
        }
    }
}
