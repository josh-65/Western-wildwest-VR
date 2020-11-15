using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeCycle : MonoBehaviour
{
    void Update()
    {
        transform.RotateAround(Vector3.zero,Vector3.right, 0.01668f*Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
