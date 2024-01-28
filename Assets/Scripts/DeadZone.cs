using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public event Action OnDead;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            OnDead?.Invoke();
        }
    }
}
