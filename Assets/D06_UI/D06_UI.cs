using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class D06_UI : MonoBehaviour
{
    public void OnClick_Destroy(GameObject Target){
      Destroy(Target);
    }

    public void OnClick_LoadScene(){
      SceneManager.LoadScene(0);
    }

}


