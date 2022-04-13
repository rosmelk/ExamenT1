using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerNinga : MonoBehaviour
{

    public float Velocidad = 10;
    public float JumpForce = 10;

    private Rigidbody2D _rigidbody2D; //variable 
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    
   
    private static readonly string animacionEstado="Estado";
    private static readonly int IDLE=0;
    private static readonly int RUN=1;
    private static readonly int JUMP=2;
    
    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

      
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = new Vector2(Velocidad, _rigidbody2D.velocity.y);
        changeAnimation(RUN);
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            changeAnimation(JUMP);
        }

    }
    
    private void changeAnimation(int animation)
    {
         _animator.SetInteger(animacionEstado, animation);
    }

}
