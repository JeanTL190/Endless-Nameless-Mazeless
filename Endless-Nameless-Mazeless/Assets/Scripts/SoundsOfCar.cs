using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsOfCar : MonoBehaviour
{
    [SerializeField] AudioSource[] audio;
    private Rigidbody2D rb;
    private float xAxis;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xAxis = Input.GetAxis("Vertical");

        if (rb.velocity.y == 0)
        {
            if(!audio[0].isPlaying)
                audio[0].Play();
            audio[1].Stop();
            audio[2].Stop();
        }
        else if (xAxis==0)
        {
            if (!audio[1].isPlaying)
                audio[1].Play();
            audio[0].Stop();
            audio[2].Stop();
            Debug.Log("Cheguei");
        }
        else
        {
            if (!audio[2].isPlaying)
                audio[2].Play();
            audio[1].Stop();
            audio[0].Stop();
        }
    }
}
