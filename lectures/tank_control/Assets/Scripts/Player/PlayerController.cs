using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;
using Quaternion = System.Numerics.Quaternion;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 100f;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpSpeed = 10f;
    [SerializeField] private Weapon weapon;
    [SerializeField] private Transform weaponLocation; //used for when we try a weapon pickup to spawn a weapon
    private Vector2 _inputVector;
    private Rigidbody _rb;

    public UnityEvent UnityPlayerHitEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //Debug.Log($"Our input values are {x}, {y}");
        _inputVector = new Vector2(x, y);
      
        transform.Rotate(new Vector3(0, 1, 0), _inputVector.x * turnSpeed * Time.deltaTime);
        transform.Translate(0, 0, _inputVector.y * moveSpeed * Time.deltaTime); //good to go over order of operations and how translate differs from just adding to the position. Note that the translation feels relative to the object's rotation
        if (Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);//it would be good to discuss a bit about force modes
        }

        if (Input.GetButtonDown("Fire1"))
        {
            weapon?.Shoot(transform.forward);//null check to see if the weapon exists
        }

    }
    private void FixedUpdate()
    {

    }

    public void ChangeWapon(Weapon newWeapon)
    {
        if (weapon != null)
        {
            Weapon oldWeapon = weapon;
            Destroy(oldWeapon.gameObject);
        }

        weapon = (Weapon)Instantiate(newWeapon, weaponLocation);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Projectile>(out Projectile projectile))
        {
            UnityPlayerHitEvent?.Invoke();
        }
    }
}
