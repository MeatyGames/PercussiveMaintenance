using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum EnemyType
{
    GroundNormal,
    GroundFast,
    GroundHeavy,

    FlyingNormal,
    FlyingFast,
    FlyingHeavy,
}

public class BaseEnemy : RenderedActor
{
    public event Action EnemyHit;
    public event Action EnemyDead;
    public float Speed;
    public EnemyType EnemyType;
    public string ID;

    public Vector3 EndPos;
	
	void Update ()
    {
        Move();
	}

    void Move()
    {
        float step = Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, EndPos, step);
    }

    

    
}
