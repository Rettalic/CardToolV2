using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateCamSize : MonoBehaviour
{/*
    public Camera _cam;
    public (Vector3 center, float size) CalculateOrthoSize()
    {
        var bounds = new Bounds();
        foreach (var col in FindObjectsOfType<Collider2D>()) bounds.Encapsulate(col.bounds);

        bounds.Expand(_buffer);
        var vertical = bounds.size.y;
        var horizontal = bounds.size.x * _cam;
        var size = Mathf.Max(horizontal, vertical) * 0.5f;

        var center = bounds.center + new Vector3(0, 0, -10);

        return (center, size);
    }*/
}
