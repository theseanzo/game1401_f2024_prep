using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;

    [SerializeField] private float shotSpeed = 100f;

    [SerializeField] private Transform fireLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        Projectile projectile = (Projectile)Instantiate(projectilePrefab, fireLocation.position, Quaternion.identity);
        projectile?.Fire(transform.up, shotSpeed); //because our gun is a cylinder, we have our direction set to the transform.up. This is not ideal.
    }

    public void Shoot(Vector3 direction)
    {
        Projectile projectile = (Projectile)Instantiate(projectilePrefab, fireLocation.position, Quaternion.identity);
        projectile?.Fire(direction, shotSpeed);
    }
}
