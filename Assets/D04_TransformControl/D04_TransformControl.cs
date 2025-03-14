using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class D04_TransformControl : MonoBehaviour
{
    void Start() {

    }

    void Update() {
      if (Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(0,1,0);
      }
      if (Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(0,-1,0);
      }
      if(Input.GetKey(KeyCode.LeftArrow)){
        transform.Rotate(0,1,0);
      }
      if(Input.GetKey(KeyCode.RightArrow)){
        transform.Rotate(0,-1,0);
      }
    }
}
