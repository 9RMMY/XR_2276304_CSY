using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class D04_Mesh_Renderer : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject MySphere, MyCapsule;

    void Start() {
      ThisMeshFilter = GetComponent<MeshFilter>();
    }

    void Update() {
      if(Input.GetMouseButtonDown(0)){
        ThisMeshFilter.mesh = MySphere.GetComponent<MeshFilter>().mesh;
      }
      if(Input.GetMouseButtonDown(1)){
        ThisMeshFilter.mesh = MyCapsule.GetComponent<MeshFilter>().mesh;
      }
    }
}
