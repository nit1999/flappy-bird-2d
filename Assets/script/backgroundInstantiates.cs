using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundInstantiates : MonoBehaviour
{
    public GameObject bg;
    void Start()
    {
        StartCoroutine(BgCoroutine());
    }


    IEnumerator BgCoroutine()
    {
        while (true)
        {
            Instantiate(bg, new Vector3(5.6f, Random.Range(1.8f, -3.21f), 0f), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);

        }
    }
    
}
