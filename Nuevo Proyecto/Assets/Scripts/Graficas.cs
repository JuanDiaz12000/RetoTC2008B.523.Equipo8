using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graficas : MonoBehaviour
{
    Vector3 a, b, c, n, centroid; //centorid es el promedio de las "x", "y" y "z"
    // Start is called before the first frame update
    void Start()
    {
        a = new Vector3(0.22f, 10f, -0.5f);
        b = new Vector3(1.13f, 2f, -1f);
        c = new Vector3(-0.7f, 5f, 0f);
        Vector3 u = b - a;
        Vector3 v = c - a;

        n = Vector3.Cross(u, v);
        Debug.Log(n.ToString("F5"));

        centroid = ((a + b + c) / 3.0f);

        Vector3 au = a.normalized; //Normalized encuentra el vector unitario
        Vector3 bu = b.normalized;

        float alpha = Mathf.Acos(Vector3.Dot(au, bu));
        Debug.Log("Alpha = " + alpha);
        Debug.Log("Alpha = " + Mathf.Rad2Deg * alpha + "º");
    }

    /* Convención para definir las caras:
     * -Comenzar en el vértice inferior izquierdo
     * -Moverse contra las manecillas del reloj
     */

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(1, 0, 0), Color.red);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 1, 0), Color.green);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 0, 1), Color.blue);

        Debug.DrawLine(a, b, Color.cyan);
        Debug.DrawLine(b, c, Color.cyan);
        Debug.DrawLine(c, a, Color.cyan);
        Debug.DrawLine(centroid, n, Color.magenta);
    }
}
