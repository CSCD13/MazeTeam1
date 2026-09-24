using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] characters;
    public Vector3 spawnPosition = new Vector3(0f, 1f, 0f);

    public void SpawnCharacter(int index) {
        Instantiate(characters[index], spawnPosition, Quaternion.identity);
    }
}
