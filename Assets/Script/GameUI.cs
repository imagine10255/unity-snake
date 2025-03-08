using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text prevScoreText;

    int score;
    int maxScore;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // scoreText.text = score.ToString();
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetScore(){
        score = 0;
        scoreText.text = score.ToString();
    }

    public void AddScore(){
        score++;
        scoreText.text = score.ToString();
    }



    // 紀錄最高分數
    public void RecordPrevScore(){
        if(score > maxScore){
            maxScore = score;
        }
        
        prevScoreText.text = maxScore.ToString();
    }
}
