using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BaseEnemy))]
public class EnemyHitEffect : MonoBehaviour
{
    public GameObject HitEffectPrefab;
    BaseEnemy Enemy;
	// Use this for initialization
	void Start ()
    {
        Enemy = GetComponent<BaseEnemy>();
        Enemy.EnemyHit += OnHit;
	}
	
    void OnHit()
    {
        var hitEffect = Instantiate(HitEffectPrefab);
        hitEffect.transform.position = Enemy.transform.position;
        Destroy(hitEffect, 5f);
    }
}
