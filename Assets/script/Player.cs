using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float speed=0f;
    public float Jumpspeed = 50f;
    public float Downspeed = 1f;
    private float forWardMove=0.3f;
    public Text scoreText;
    public int count;
    public static int totalCount=0;


    public AudioClip BirdmoveSound;
    public AudioClip GetScoreSound;


    void Update()
    {
        
   
        transform.Translate(Vector2.down * Downspeed * Time.deltaTime);
       //  if (Input.GetButtonDown("Jump"))
       // {
            // if (Input.touchCount > 0) { 
             if (Input.GetMouseButtonDown(0)) { 
            AudioSource moveSound = GetComponent<AudioSource>();
            moveSound.PlayOneShot(BirdmoveSound);
            Vector2 vr = new Vector2(0, 5);
            transform.Translate(vr * Jumpspeed * Time.deltaTime);
            transform.Translate(Vector2.right * forWardMove * Time.deltaTime);

        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "score")
        {
            count++;
            scoreText.text = " " + count;
            AudioSource PointSound = GetComponent<AudioSource>();
            PointSound.PlayOneShot(GetScoreSound);
        }

        if (other.tag == "Destroy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("restart 1");

        }

        totalCount = count;

    }


}