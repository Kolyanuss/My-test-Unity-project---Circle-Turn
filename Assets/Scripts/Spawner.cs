using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform centerSpawnPointEnemy;
    private float _range;

    [SerializeField] float RangeReadOnly;
    [SerializeField] GameObject enemy;

    void Start()
    {
        _range = centerSpawnPointEnemy.localScale.y / 2;
        RangeReadOnly = _range;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = centerSpawnPointEnemy.position + new Vector3(0, Random.Range(-_range, _range));
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
