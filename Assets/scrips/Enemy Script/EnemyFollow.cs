using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyFollow : MonoBehaviour
{

    private Transform targetPlayer;
    public float speed;
    public UnityEvent Galaw;

   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Galaw.Invoke();
        
    }

    public void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime);
    }
}
