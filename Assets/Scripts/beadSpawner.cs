using UnityEngine;

public class beadSpawner : MonoBehaviour { // 공 자동 생성기
    public GameObject beadPrefab; // 공 프리팹
    public float spawnInterval = 1.0f; // 공 생성 간격
    public float xRange = 2.0f; // X축 랜덤 범위

    void Start() {
        InvokeRepeating("beadSpawn", 0.1f, spawnInterval);
    }

    void beadSpawn() {
        float randX = Random.Range(-xRange, xRange); // -2 <= x <= 2 사이 랜덤한 X축 위치에 공 생성
        Vector3 spawnPosition = new Vector3(randX, 15, 0);
        Instantiate(beadPrefab, spawnPosition, Quaternion.identity);
    }
}
