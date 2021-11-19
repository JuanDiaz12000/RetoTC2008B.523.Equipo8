using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiCubo : MonoBehaviour
{

    Vector3[] geometria;
    int[] topologia;
    Mesh malla;
    float ry;
    int size = 10;

    Vector3[] ApplyTransform(float rotY){
        Vector3[] transform = new Vector3[geometria.Length];
        Matrix4x4 rm = Transformations.RotateM(40, Transformations.AXIS.AX_Y);
        for (int i = 0; i < geometria.Length; i++)
        {
            Vector3 v = geometria[i];
            Vector4 temp = new Vector4(v.x, v.y, v.z, 1);
            transform[i]= rm * temp;
        }
        return transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        //int size = 10;
        MeshFilter mf = gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        malla = mf.mesh;

        geometria = new Vector3[]
        {
            new Vector3(0, 0, size),
            new Vector3(size, 0, size),
            new Vector3(size, size, size),
            new Vector3(0, size, size),
            new Vector3(size, 0, 0),
            new Vector3(size, size, 0),
            new Vector3(0, 0, 0),
            new Vector3(0, size, 0),
        };

        topologia = new int[] { 
            0, 1, 2, 0, 2, 3,
            1, 4, 2, 2, 4, 5,
            3, 2, 5, 3, 5, 7,
            6, 0, 3, 6, 3, 7,
            4, 6, 5, 6, 7, 5,
            6, 4, 0, 4, 1, 0, };

        malla.vertices = geometria;
        malla.triangles = topologia;
        malla.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        ry += 0.1f;
        malla.vertices = ApplyTransform(ry);
    }
}
