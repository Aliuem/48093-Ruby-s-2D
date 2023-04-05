using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubycontroller : MonoBehaviour
{  

      Rigidbody2D rigidbody2d;
    float horizontal; 
    float vertical;


    // Start is called before the first frame update
    void Start()

    {  
         rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
         float horizontal = Input.GetAxis("Horizontal");
      Debug.Log(horizontal);
         Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;
    }
}
