using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    public string[] staticDirection = { "Static N", "Static NW", "Static W", "Static SW", "Static S", "Static SE", "Static E", "Static NE"};
    public string[] runDirection = { "Run N", "Run NW", "Run W", "Run SW", "Run S", "Run SE", "Run E", "Run NE"};
    int lastDirection;
    private void Awake()
    {
        anim = GetComponent<Animator>();
       float result = Vector2.SignedAngle(Vector2.up, Vector2.right);
       Debug.Log("R1 " + result);
        float result1 = Vector2.SignedAngle(Vector2.up, Vector2.left);
        Debug.Log("R1 " + result1);
        float result2 = Vector2.SignedAngle(Vector2.up, Vector2.down);
        Debug.Log("R1 " + result2);

    }
    public void SetDirection(Vector2 _direction)
    {
        string[] directionArray = null;
        if (_direction.magnitude < 0.01)
        {
            directionArray = staticDirection;
        }
        else
        {
            directionArray = runDirection;
            lastDirection = DirectionToIndex(_direction);
        }

        anim.Play(directionArray[lastDirection]);
    }

    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;
        float step = 360/8;
        float offset = step /2;

        float angle = Vector2.SignedAngle(Vector2.up, norDir);

        angle += offset;
        if (angle < 0)
        {
            angle += 360;
        }
        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
      
    }
}
