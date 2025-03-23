using UnityEngine;

public class PinSpawner : MonoBehaviour { // 페그 자동 생성기
    public GameObject pegPrefab;
    public Transform referencePeg; // 기준 페그
    public int rows = 8; // 행 개수
    public int cols = 7; // 열 개수
    public float spacing = 1.0f; // 페그 간격

    void Start() {
        spawnPegs();
    }

    void spawnPegs() {
        if (referencePeg == null) {
            Debug.LogError("Reference Peg가 설정되지 않았습니다.");
            return;
        }

        float startY = referencePeg.position.y; // 기준 페그의 y좌표
        float totalWidth = (cols - 1) * spacing; // 전체 너비
        float startX = -totalWidth / 2; // x좌표 중심 정렬
        float firstRowY = startY; // 첫 번째 페그의 y좌표 = 기준 페그의 y좌표

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                float xOffset = (row % 2 == 0) ? 0 : spacing * 0.5f; // 홀수 행이면 x 오프셋 적용
                float x = startX + col * spacing + xOffset; // 페그들이 어긋나게 배치되도록
                float y = firstRowY - row * spacing;
                Vector3 position = new Vector3(x, y, 0);
                Instantiate(pegPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}