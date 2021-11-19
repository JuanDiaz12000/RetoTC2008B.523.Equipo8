using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malla : MonoBehaviour
{
    Vector3[] geometria;
    int[] topologia;
    Mesh malla;
    // Start is called before the first frame update
    void Start()
    {
        int size = 10;
        MeshFilter mf = gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        malla = mf.mesh;

        geometria = new Vector3[]
        {
            new Vector3(0.22f, 10f, -0.5f),
            new Vector3(1.13f, 2f, -1f),
            new Vector3(-0.7f, 5f, 0f)
        };

        topologia = new int[] { 0, 1, 2 };

        malla.vertices = geometria;
        malla.triangles = topologia;
        malla.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
