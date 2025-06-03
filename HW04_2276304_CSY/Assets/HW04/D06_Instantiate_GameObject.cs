using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Instantiate_GameObject : MonoBehaviour
{
    public GameObject Target;       // 복제할 원본
    public int cloneCount = 10;     // 복제할 수량
    private bool alreadySpawned = false; // 중복 방지

    public void SpawnItems()
    {
        Debug.Log("SpawnItems 실행됨");
        if (alreadySpawned) return;

        int itemsToShow = DataManager.Instance.totalItemCount - DataManager.Instance.pickCount;

        for (int i = 0; i < itemsToShow; i++)
        {
            Vector3 randomSphere = Random.insideUnitSphere * 5f;
            randomSphere.y = 0f;
            Vector3 randomPos = transform.position + randomSphere + Vector3.up * 1.5f; // 위로 1.5m 올림


            float randomAngle = Random.value * 360f;
            Quaternion randomRot = Quaternion.Euler(0, randomAngle, 0);

            GameObject Clone = Instantiate(Target, randomPos, randomRot);
            Clone.SetActive(true);
            Clone.name = "Clone-" + string.Format("{0:D4}", i);
            Clone.transform.SetParent(transform);
        }

        alreadySpawned = true;
    }
}
