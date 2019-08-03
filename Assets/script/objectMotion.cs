using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMotion : MonoBehaviour
{
    public float speed = 6f;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(transform.position.x == -21.18f)
        {
            Destroy(gameObject);
        }
      
    }

}
