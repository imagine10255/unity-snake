using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class GameUI : MonoBehaviour
{
        [DllImport("__Internal")]
  private static extern void SetScore (int score);


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

        #if UNITY_WEBGL == true && UNITY_EDITOR == false
            SetScore(score);
        #endif

       
    }



    // 紀錄最高分數
    public void RecordPrevScore(){
        if(score > maxScore){
            maxScore = score;
        }
        
        prevScoreText.text = maxScore.ToString();
    }



    // 紀錄最高分數
    public void SetMaxScore(int newScore){
        maxScore = newScore;
        prevScoreText.text = newScore.ToString();
    }
}
