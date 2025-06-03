using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class D06_UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;
    public TMP_Text PutCounts;

    public Button fireButton; // ← 발사 버튼

    void Start()
    {
        Display_PickCounts();
        Display_PutCounts();
        UpdateFireButton();
    }

    public void Display_PickCounts()
    {
        PickCounts.text = DataManager.Instance.pickCount.ToString();
        UpdateFireButton();
    }

    public void Display_PutCounts()
    {
        PutCounts.text = DataManager.Instance.putCount.ToString();
    }

    void UpdateFireButton()
    {
        if (fireButton != null)
        {
            fireButton.interactable = DataManager.Instance.pickCount > 0;
        }
    }
}
