using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private string Run, Attack;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void StartRun()
    {
        _animator.SetBool(Run, true);
    }
    public void StopRun()
    {
        _animator.SetBool(Run, false);
    }
    
    public void StartAttack()
    {
        _animator.SetBool(Attack, true);
    }
    public void StopAttack()
    {
        _animator.SetBool(Attack, false) ;
    }
    void Update()
    {
        if (_rigidbody.velocity != Vector2.zero)
            print("YES");
    }
}
