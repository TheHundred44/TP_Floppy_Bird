using System;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public event Action OnDead;

    public event Action OnDeadSong;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            OnDead?.Invoke();
            OnDeadSong?.Invoke();
        }
    }
}
