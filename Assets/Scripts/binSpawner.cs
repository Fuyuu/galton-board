using UnityEngine;

public class binSpawner : MonoBehaviour { // 공 바구니 자동 생성기
    public GameObject binPrefab;
    public int binCount = 7; // 바구니 개수
    public float spacing = 1.0f; // 바구니 간격

    void Start() {
        for (int i = 0; i <= (binCount / 2) + 1; i++) {
            float x1 = i * spacing;
            float x2 = -i * spacing;

            Vector3 position1 = new Vector3(x1, -4, 0);
            Vector3 position2 = new Vector3(x2, -4, 0);

            Instantiate(binPrefab, position1, Quaternion.identity, transform);
            Instantiate(binPrefab, position2, Quaternion.identity, transform);
        }
    }
}