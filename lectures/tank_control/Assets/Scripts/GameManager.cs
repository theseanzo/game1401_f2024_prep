using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    private Collectable[] _collectables;

    private float _scoreTotal = 0;
    private float _gameTime = 0;
    void Start()
    {
        _collectables = FindObjectsOfType<Collectable>(); //global function, allows you to find everything 
        foreach (Collectable collectable in _collectables)
            collectable.Manager = this;
    }

    public void AddScore(int score)
    {
        _scoreTotal += score;
        Debug.Log($"Our new total score is {_scoreTotal}");
    }
    // Update is called once per frame
    void Update()
    {
        _gameTime += Time.deltaTime;
    }
}
