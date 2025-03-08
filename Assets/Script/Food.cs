using UnityEngine;

public class Food : MonoBehaviour
{

    public Collider2D foodArea;

    void Start()
    {
        RandomPosition();
    }

    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision);

        // Debug.Log(foodArea.bounds.min.x);
        // Debug.Log(foodArea.bounds.max.x);

        // Debug.Log(foodArea.bounds.min.y);
        // Debug.Log(foodArea.bounds.max.y);

       RandomPosition();
    }

    // 隨機位置
    void RandomPosition(){
         transform.position = new Vector3(
            Random.Range(foodArea.bounds.min.x, foodArea.bounds.max.x),
            Random.Range(foodArea.bounds.min.y, foodArea.bounds.max.y),
            0
        );
    }
}
