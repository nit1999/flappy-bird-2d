using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiates : MonoBehaviour
{
    public GameObject object1;

    void Start()
    {
        // transform.position = new Vector2(-1, 0);
        StartCoroutine(PowerUpCoroutine());

    }

    IEnumerator PowerUpCoroutine()
    {
        while (true)
        {
            Instantiate(object1, new Vector3(6.18f, Random.Range(-1f,3f), 0f), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }
}