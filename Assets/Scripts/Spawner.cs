using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform centerSpawnPointEnemy;
    private float _range;

    [SerializeField] float RangeReadOnly;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bonus;

    void Start()
    {
        _range = centerSpawnPointEnemy.localScale.y / 2;
        RangeReadOnly = _range;
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnBonus());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1.5f);
        Vector2 pos = centerSpawnPointEnemy.position + new Vector3(0, Random.Range(-_range, _range));
        Instantiate(enemy, pos, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }
    
    IEnumerator SpawnBonus()
    {
        yield return new WaitForSeconds(2);
        Vector2 pos2 = centerSpawnPointEnemy.position + new Vector3(0, Random.Range(-(_range - 1), _range - 1));
        Instantiate(bonus, pos2, Quaternion.identity);
        StartCoroutine(SpawnBonus());
    }

}
