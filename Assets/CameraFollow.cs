using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public GameObject tagget;
    public float x;
    public float y;
    public float z;

    void Update()
    {
        //new Vector3(x, y, z) de cho minh co the nhin thay tu xa
        transform.position = tagget.transform.position + new Vector3(x, y, z);
        // huong ve phia cua dt can theo
        transform.LookAt(tagget.transform.position);

    }
}
