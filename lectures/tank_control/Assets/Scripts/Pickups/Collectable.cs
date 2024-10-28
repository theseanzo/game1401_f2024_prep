using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1;
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
        if (other.GetComponent<PlayerController>()) //it would be good to show this logic can exist on the player or the collectable and explain where it's best to be
        {
            GameManager.Instance.AddScore(scoreValue);
            Destroy(this.gameObject); 
        }
    }
}
