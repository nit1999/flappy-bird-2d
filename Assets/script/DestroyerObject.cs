using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "score")
        {
            Destroy(other.gameObject);
        }
    }
}
