using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHitter : MonoBehaviour  
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>(); //we call "GetComponent<AudioSource>()" and it will return an AudioSource if it is on the root level Game Object
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Ow you hit me");//in Unity we use Debug.Log rather than Console.WriteLine. This is because you are printing to Unity's debug rather than the Console.
        _audioSource?.Play(); //the ? is a null check. If the _audioSource is null you will not get a value
    }
}
