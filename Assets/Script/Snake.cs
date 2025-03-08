using System.Collections.Generic;
using UnityEngine;


public class Snake : MonoBehaviour
{

    public GameUI gameUI;
    public GameAudio gameAudio;
    
    Vector3 direction;
    public float speed;
    public Transform bodyPrefab;

    public List<Transform> bodies = new List<Transform>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log(transform.position.x);
        // transform.Translate(-1, 2, 3);

        Time.timeScale = speed;

        ResertStage();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && direction != Vector3.down){
            // Debug.Log("W");
            // transform.Translate(0, 1, 0);
            direction = Vector3.up;
        }
          if(Input.GetKeyDown(KeyCode.LeftArrow) && direction != Vector3.right){
            // Debug.Log("A");
            // transform.Translate(-1, 0, 0);
           
            direction = Vector3.left;    
           
            
        }
          if(Input.GetKeyDown(KeyCode.DownArrow) && direction != Vector3.up){
            // Debug.Log("S");
            // transform.Translate(0, -1, 0);
            direction = Vector3.down;
        }
          if(Input.GetKeyDown(KeyCode.RightArrow) && direction != Vector3.left){
            // Debug.Log("D");
            // transform.Translate(1, 0, 0);
            direction = Vector3.right;
        }

        
    }


    void FixedUpdate()
    {
        for(int i = bodies.Count - 1; i > 0; i--)
        {
            bodies[i].position = bodies[i - 1].position;
        }



        transform.Translate(direction);
    }



    // 觸發進入
    void OnTriggerEnter2D(Collider2D collision)
    {
        // 當吃掉頻果
        if(collision.CompareTag("Food")){
            // Debug.Log(collision);
            // Instantiate(bodyPrefab);
            bodies.Add(
                Instantiate(bodyPrefab,
                transform.position
                , Quaternion.identity
            ));

            gameUI.AddScore();
            gameAudio.PlayEatSound();
        }

        // 當撞到障礙物
        if(collision.CompareTag("Obstacle")){
            Debug.Log("Game over");

            gameUI.RecordPrevScore();
            ResertStage();
            gameAudio.ReplayBackgroundMusic();
        }
        
    }

    // 重置場景
    void ResertStage(){
            transform.position = Vector3.zero;
            direction = Vector3.zero;

            for(int i = 1; i < bodies.Count; i++)
            {
                Destroy(bodies[i].gameObject);
            }
            bodies.Clear();
            bodies.Add(transform);

            gameUI.ResetScore();
    }

    // 設定最高分數並且測試 React 呼叫 Unity方法
       public void SpawnEnemies (int score) {
         gameUI.SetMaxScore(score);
        }


}
