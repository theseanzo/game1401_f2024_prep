using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected Projectile projectilePrefab;

    [SerializeField] protected float shotSpeed = 100f;

    [SerializeField] protected Transform fireLocation;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public virtual void Shoot()
    {
        Projectile projectile = (Projectile)Instantiate(projectilePrefab, fireLocation.position, Quaternion.identity);
        projectile?.Fire(transform.up, shotSpeed); //because our gun is a cylinder, we have our direction set to the transform.up. This is not ideal.
    }

    public virtual void Shoot(Vector3 direction)
    {
        Projectile projectile = (Projectile)Instantiate(projectilePrefab, fireLocation.position, Quaternion.identity);
        projectile?.Fire(direction, shotSpeed);
    }
}
