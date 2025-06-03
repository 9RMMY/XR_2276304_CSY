using UnityEngine;
using Vuforia;

public class TargetRecognitionHandler : MonoBehaviour
{
    private ObserverBehaviour observer;
    public D06_Instantiate_GameObject spawner;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer != null)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED)
        {
            spawner.SpawnItems(); // 인식되면 하트 복제 시작
        }
    }
}
