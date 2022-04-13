using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerZombiSaltar : MonoBehaviour
{
    public float fuerzaSalto = 1;
    
    private Rigidbody2D _rigidbody2D; //variable 
    void Start()
    {
     
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
            _rigidbody2D.AddForce(Vector2.up*fuerzaSalto,ForceMode2D.Impulse);
       
            
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        var tag = other.gameObject.tag;
        if (tag=="Zombi")
        {
            
            Destroy(other.gameObject); 
        }
        
    }
    
}
