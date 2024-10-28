using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: MonoBehaviour //this will be very confusing for people! First time using generics. Need to explain what generics are
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();//logic for this: if we have not found a version of this object yet, we need to go and find the one in our scene
            }

            return _instance;
        }//note that there is no "set" for a singleton.
    }
}
