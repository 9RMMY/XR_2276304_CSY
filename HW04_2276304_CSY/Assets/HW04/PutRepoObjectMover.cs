using System.Collections;
using UnityEngine;

public class PutRepoObjectMover : MonoBehaviour
{
    public Vector3 centerPosition = Vector3.zero; // 기준 중심 위치
    public float moveRange = 1f;                  // 랜덤 이동 범위
    public float minInterval = 0.5f;
    public float maxInterval = 1f;

    void Start()
    {
        StartCoroutine(MoveRandomly());
    }

    IEnumerator MoveRandomly()
    {
        while (true)
        {
            // 1. 랜덤 시간 대기
            float waitTime = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(waitTime);

            // 2. 새로운 랜덤 위치 계산
            Vector3 randomOffset = new Vector3(
                Random.Range(-moveRange, moveRange),
                0,
                Random.Range(-moveRange, moveRange)
            );
            Vector3 newPos = centerPosition + randomOffset;

            // 3. 이동
            transform.position = newPos;
        }
    }
}
