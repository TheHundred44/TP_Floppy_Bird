using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Material _mat;
    private float _distance;

    [Range(0f, 0.5f)]
    public float Speed = 0.2f;

    private void Start()
    {
        _mat = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        _distance += Time.deltaTime * Speed;
        _mat.SetTextureOffset("_MainTex", Vector2.right* _distance);
    }
}
