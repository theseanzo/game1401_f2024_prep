using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Turret : MonoBehaviour
{
    [FormerlySerializedAs("cannon")] [SerializeField] private GameObject cannonPivot;

    [SerializeField] private GameObject target;

    [SerializeField] private float fireDelay = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    { 
        Vector3 targetDirection = (target.transform.position - transform.position).normalized; 
        //it may be easier to show this by using "Vector3.RotateTowards" as you can then showcase this for rotating over time
        cannonPivot.transform.rotation = Quaternion.LookRotation(targetDirection); //we are rotating the pivot, and not the cannon. It would be good to explain why this is and go over how rotations work in Unity
    }
}
