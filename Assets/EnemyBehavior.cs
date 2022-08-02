using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float m_TresholdPositionZ = -30.0f;

    public Stats stats;

    private const string Player = "Player";

    private PlayerBehavior m_Pc;

    public float speed;
 
    void Awake()
    {
       stats = GetComponent<Stats>();
    }

    void Start() 
    {
        stats = GetComponent<Stats>();
        
        m_Pc = GameObject.Find("Player")
                        .GetComponent<PlayerBehavior>();

    }


    public void Update() 
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - speed * Time.deltaTime
        );

        if(Vector3.Distance(m_Pc.transform.position, transform.position) <= 1.0f)
        {
             m_Pc.ReceiveDamage();
             Destroy(gameObject);
        }

        if(transform.position.z <= m_TresholdPositionZ) 
        {
            Destroy(gameObject);
        }


    }




}
