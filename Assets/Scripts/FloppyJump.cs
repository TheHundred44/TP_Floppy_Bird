using System;
using UnityEngine;

public class FloppyJump : MonoBehaviour
{
    private Floppy _floppy;

    public event Action OnJump;

    public event Action OnJumpSong;

    [SerializeField]
    private float _strengtJump = 5f;

    private void Awake()
    {
        _floppy = this.GetComponent<Floppy>();
    }

    public void Jump()
    {
        OnJump?.Invoke();
        OnJumpSong?.Invoke();
        _floppy.GetComponent<Rigidbody>().velocity = Vector2.up * this._strengtJump;
    }
}
