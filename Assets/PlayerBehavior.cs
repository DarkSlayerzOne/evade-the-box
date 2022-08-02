using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
     public Stats stats;

     public float speed;

    public Transform leftWall;

    public Transform rightWall;

    private const string Enemy = "Enemy";

    void Awake()
    {
        stats = GetComponent<Stats>();
    }
    
    // void Start()
    // {
    //     var gameObject = GameObject.Find(Enemy)
    //                                .GetComponent<EnemyBehavior>();
    // }
    

    void Update()  
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var hoizontalPosition = transform.position.x + horizontalInput * speed * Time.deltaTime;

        var playerSize = transform.localScale.x / 2;
        var leftWallScale =  leftWall.localScale.x / 2;
        var rightWallScale = rightWall.localScale.x / 2;

        if(hoizontalPosition - playerSize <= leftWall.position.x + leftWallScale) 
        {
            return;
        }

        if(hoizontalPosition + playerSize  >= rightWall.position.x - rightWallScale)
        {
            return;
        }

        transform.position = new Vector3(
            hoizontalPosition,
            1, 
            transform.position.z);
       
    } 


    public void ReceiveDamage() 
    {
       stats.UpdateHealth(10);
    } 

}
