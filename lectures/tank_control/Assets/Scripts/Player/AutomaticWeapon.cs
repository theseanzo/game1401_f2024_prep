using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutomaticWeapon : Weapon
{
    [SerializeField] private float fireDelay = 2f;
    [SerializeField] private int ammo = 100;
    protected override void Start()
    {
        base.Start();
       // StartCoroutine(Firing());//write this before showing the event way to do this with StartFiring

    }

    public void StartFiring()
    {
        StartCoroutine(Firing());
    }

    public void StopFiring()
    {
        StopAllCoroutines(); //it also may be good to showcase them storing corouting to stop specific coroutines from running, but this will be covered in later lessons as well.
    }
    IEnumerator Firing()
    {
        while (ammo > 0) //best to show just shooting before there's ammo, but this is a nice tweak for the class.
        {
            base.Shoot();
            ammo--;
            yield return new WaitForSeconds(fireDelay);
            
        }

    }
    
}
