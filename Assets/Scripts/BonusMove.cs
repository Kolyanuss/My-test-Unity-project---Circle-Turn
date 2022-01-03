using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMove : MonoBehaviour
{
    [SerializeField] GameObject Bonus;
    [SerializeField] float speed;
    void Start()
    {

    }

    void FixedUpdate()
    {
        Bonus.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
