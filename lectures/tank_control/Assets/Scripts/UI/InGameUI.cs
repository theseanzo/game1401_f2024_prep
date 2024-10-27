using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(float score)
    {
        scoreText.text = $"Score: {score}";
    }

    public void UpdateTime(float time)
    {
        timeText.text = string.Format("{0:0.##}", time);
    }
}
