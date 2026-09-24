using UnityEngine;

public class Character1Changer : MonoBehaviour
{
    [SerializeField] private GameObject newPlayerPrefab;

    public void SwapPlayer() {
        GameObject currentPlayer = GameObject.FindGameObjectWithTag("Player");

        if (currentPlayer != null && newPlayerPrefab != null) {
            Instantiate(newPlayerPrefab, currentPlayer.transform.position, currentPlayer.transform.rotation);
            Destroy(currentPlayer);
        } 
    }
}