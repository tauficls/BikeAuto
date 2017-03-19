using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public AudioSource collideSound;
    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("enter");
        collideSound.Play();

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("enter");
        collideSound.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
