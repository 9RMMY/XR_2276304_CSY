using UnityEngine;
using Vuforia;

public class BowlActivationHandler : MonoBehaviour
{
    public GameObject bowlObject;   // 타겟 바깥에 있는 bowl
    public GameObject arUIGroup;    // fireButton, 조준점 묶은 UI 그룹
    private ObserverBehaviour observer;
    private bool hasActivated = false; // 이미 활성화했는지 여부

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        if (bowlObject) bowlObject.SetActive(false);
        if (arUIGroup) arUIGroup.SetActive(false);
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if ((status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED) && !hasActivated)
        {
            // bowl 활성화 + 위치 조정
            if (bowlObject)
            {
                bowlObject.SetActive(true);
                bowlObject.transform.position = behaviour.transform.position + new Vector3(0, 0.1f, 0);
                bowlObject.transform.rotation = behaviour.transform.rotation;
            }

            // UI 그룹 (버튼, 조준점) 등장
            if (arUIGroup)
            {
                arUIGroup.SetActive(true);

                // 필요 시 pickCount 반영
                arUIGroup.GetComponent<D06_UI_Controller>()?.Display_PickCounts();
            }

            hasActivated = true;
        }
    }
}
