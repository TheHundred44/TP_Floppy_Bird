using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloppyJump : MonoBehaviour
{
    private Floppy _floppy;

    public event Action OnJump;

    [SerializeField]
    private float _strengtJump = 5f;

    private void Awake()
    {
        _floppy = this.GetComponent<Floppy>();
    }
    public void Jump()
    {
        OnJump?.Invoke();
        _floppy.GetComponent<Rigidbody>().velocity = Vector2.up * this._strengtJump;
    }
}
