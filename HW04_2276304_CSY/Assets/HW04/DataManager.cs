using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public int pickCount = 0;
    public int putCount = 0;

    public int totalItemCount = 10;  // 총 아이템 개수, 원하는 값으로 설정

    public List<string> pickedItemIDs = new List<string>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
