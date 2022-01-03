using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed;
    void Start()
    {

    }

    void FixedUpdate()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
