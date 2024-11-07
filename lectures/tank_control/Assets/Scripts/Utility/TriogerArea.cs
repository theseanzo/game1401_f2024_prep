using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerArea : MonoBehaviour
{
    public UnityEvent PlayerEnterEvent, PlayerExitEvent;

    public UnityEvent<GameObject> ObjectEnterEvent, ObjectExitEvent; //this will be shown to showcase a generic entering and exiting of a trigger area
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            PlayerEnterEvent?.Invoke();
        }
        //ObjectEnterEvent?.Invoke(other.gameObject);//This is a way to showcase generic object entering and informing. Brief mention of generics, which will be covered in more detail later
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            PlayerExitEvent?.Invoke();
        }
        //ObjectExitEvent?.Invoke(other.gameObject);//This is a way to showcase generic object entering and informing. Brief mention of generics, which will be covered in more detail later
    }
}
