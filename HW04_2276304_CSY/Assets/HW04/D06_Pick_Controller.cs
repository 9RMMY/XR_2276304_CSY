using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Pick_Controller : MonoBehaviour
{
    public GameObject UI;

    public void Add_Click(GameObject Clone)
    {
        DataManager.Instance.pickCount++;
        Destroy(Clone);
        UI.GetComponent<D06_UI_Controller>().Display_PickCounts();
    }
}
