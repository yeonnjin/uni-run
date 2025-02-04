﻿using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    // 가로 길이를 측정하는 처리
    private void Awake() {
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    // 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 리셋
    private void Update() {
        if (-width >= transform.position.x)
            Reposition();
    }

    // 위치를 리셋하는 메서드
    private void Reposition() {
        transform.position += new Vector3(width * 2f, 0, 0);
    }
}