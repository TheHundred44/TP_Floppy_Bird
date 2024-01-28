using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Material _mat;
    private float distance;

    [Range(0f, 0.5f)]
    public float Speed = 0.2f;

    private void Start()
    {
        _mat = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        distance += Time.deltaTime * Speed;
        _mat.SetTextureOffset("_MainTex", Vector2.right* distance);
    }
}
