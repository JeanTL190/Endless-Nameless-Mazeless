using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitoria : MonoBehaviour
{
    private  AudioSource audio;
    [SerializeField] private GameObject painelVit;
    [SerializeField] private LayerMask platformLayerMask;
    [SerializeField] private SoundsOfCar sc;
    [SerializeField] private RestartScene rs;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && (((1 << collision.gameObject.layer) & platformLayerMask) != 0))
        {
            audio.Stop();
            painelVit.SetActive(true);
            //Time.timeScale = 0f;
            sc.Lost();
            rs.Lost();
        }
    }
}
