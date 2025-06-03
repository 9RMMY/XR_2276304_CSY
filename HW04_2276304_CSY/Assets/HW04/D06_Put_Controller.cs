using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Put_Controller : MonoBehaviour
{
    public GameObject TargetObjectToThrow;
    public Transform PlayerCamera;
    public GameObject UI;

    // 버튼에서 호출할 함수
    public void ManualThrow()
    {
        if (DataManager.Instance.pickCount > 0)
        {
            Throw();
            DataManager.Instance.pickCount--;

            // UI 갱신
            if (UI != null)
            {
                var uiController = UI.GetComponent<D06_UI_Controller>();
                uiController.Display_PickCounts();
                uiController.Display_PutCounts();
            }
        }
    }

    void Throw()
    {
        Vector3 Pos = PlayerCamera.position + PlayerCamera.forward;

        float randomAngleX = Random.value * 360f;
        float randomAngleY = Random.value * 360f;
        float randomAngleZ = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(randomAngleX, randomAngleY, randomAngleZ);

        GameObject Clone = Instantiate(TargetObjectToThrow, Pos, randomRot);
        Clone.SetActive(true);

        var col = Clone.GetComponent<Collider>();
        if (col != null) col.isTrigger = false;

        var rb = Clone.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = true;
            rb.AddForce(PlayerCamera.forward * 400f);
        }

        Destroy(Clone, 3);
    }
}
