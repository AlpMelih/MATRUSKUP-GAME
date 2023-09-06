using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text MaxScoreText;
    public int MaxScore;
    public int Point=0;
    public GameObject NextLevelScreen;
    public AudioSource CollectStarAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = Point.ToString();
        MaxScoreText.text = MaxScore.ToString();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Point == MaxScore)
        {
            NextLevelScreen.SetActive(true);
         
            
        }
    }
    public void CollectStar()
    {
        Point++;
        ScoreText.text = Point.ToString();
    }
}
