using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FloppyAnimation : MonoBehaviour
{
    [SerializeField]
    private FloppyJump _floppyJump;

    private Animator _animator;

    public void Start()
    {
        _animator = GetComponent<Animator>();
        _floppyJump.OnJump += PlayJumpAnimation;
    }

    public async void PlayJumpAnimation()
    {
        _animator.Play("FloppyJump");
        _animator.SetBool("Up", true);
        await Task.Delay(200);
        _animator.SetBool("Up", false);
    }
}
