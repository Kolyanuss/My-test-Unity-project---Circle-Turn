using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallRotation : MonoBehaviour
{
    [SerializeField] Transform tr;
    public float speed = 160;
    public bool direct;

    private void Start()
    {
        tr = GetComponent<Transform>();
        direct = false;
    }

    void FixedUpdate()
    {
        if (direct)
        {
            tr.Rotate(0, 0, speed * Time.deltaTime);
        }
        else
        {
            tr.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            direct = !direct;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            direct = !direct;
        }
    }
}
