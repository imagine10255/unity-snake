using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip eatClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 播放背景音樂
    public void ReplayBackgroundMusic(){
        audioPlayer.Play();
    }


    // 播放吃的音樂
    public void PlayEatSound(){
        audioPlayer.PlayOneShot(eatClip);
    }
}
