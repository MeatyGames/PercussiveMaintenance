using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathEffect : MonoBehaviour
{

    public GameObject DeathEffectPrefab;
    BaseEnemy Enemy;
    // Use this for initialization
    void Start()
    {
        Enemy = GetComponent<BaseEnemy>();
        Enemy.EnemyDead += OnDeath;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            OnDeath();
            Destroy(gameObject);
        }   
    }

    void OnDeath()
    {
        var hitEffect = Instantiate(DeathEffectPrefab);
        hitEffect.transform.position = Enemy.transform.position;
        Destroy(hitEffect, 5f);
    }
}
