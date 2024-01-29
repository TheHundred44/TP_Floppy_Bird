using System;
using UnityEngine;

public class ZoneScore : MonoBehaviour
{
    public event Action OnScore;

    public event Action OnScoreSong;

    private void OnTriggerEnter(Collider _collider)
    {
        if (_collider.tag == "Pipe")
        {
            OnScore?.Invoke();
            OnScoreSong?.Invoke();
        }
    }
}
