using UnityEngine;

public class pegSpawner : MonoBehaviour {
    public GameObject pegPrefab;
    public int rows = 6; // 핀의 행 개수
    public float spacing = 1.0f; // 핀 간격

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        spawnPegs();
    }

    // Update is called once per frame
    void spawnPegs() {
        for (int row = 0; row < rows; row++) {
            int pegsInRow = row + 1;  // 삼각형 형태: 각 행마다 1개씩 증가
            float rowOffset = -row * 0.5f * spacing;  // 중앙 정렬을 위한 오프셋

            for (int i = 0; i < pegsInRow; i++) {
                float x = rowOffset + i * spacing;  // 좌우 위치 조정
                float y = 5 - row * spacing;  // 행(row)별 Y축 위치
                Vector3 position = new Vector3(x, y, 0);
                Instantiate(pegPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}