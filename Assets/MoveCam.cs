using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        this.transform.position = target.position + new Vector3(0,0,-20);
    }
}
