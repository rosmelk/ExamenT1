using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerZombi : MonoBehaviour
{
    
  
    private SpriteRenderer _renderer;
    
    // Start is called before the first frame update
    void Start()
    {
      
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
        _renderer.flipX = true;
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
