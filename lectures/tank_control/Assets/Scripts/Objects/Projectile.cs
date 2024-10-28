using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(Vector3 direction, float speed)
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(direction * speed, ForceMode.Impulse);//make sure to go over force modes for this
        Destroy(this.gameObject, 2f);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject, .2f);
    }
}
