using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Our GameManager has become a singleton, which means we can now communicate with it publicly. This also means that there can only be one in the scene; make sure people are aware of this.
/// </summary>
public class GameManager : Singleton<GameManager> 
{
    [SerializeField] private InGameUI inGameUI;
    // Start is called before the first frame update
    private Collectable[] _collectables;
    private float _scoreTotal = 0;
    private float _gameTime = 0;
    void Start()
    {
        _collectables = FindObjectsOfType<Collectable>(); //global function, allows you to find everything 
    }

    public void AddScore(int score)
    {
        _scoreTotal += score;
        inGameUI.UpdateScore(_scoreTotal);
    }
    // Update is called once per frame
    void Update()
    {
        _gameTime += Time.deltaTime;
        inGameUI.UpdateTime(_gameTime);
    }
}
