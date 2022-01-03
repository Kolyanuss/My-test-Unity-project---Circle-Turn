using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallRotation : MonoBehaviour
{
    [SerializeField] Transform tr;
    [SerializeField] Text textSpeed;
    public float speed = 160;
    public bool direct;

    private void Start()
    {
        tr = GetComponent<Transform>();
        direct = false;
        textSpeed.text = "Left";
    }

    void FixedUpdate()
    {
        if (direct)
        {
            tr.Rotate(0, 0, speed * Time.deltaTime);
            textSpeed.text = "Left";
        }
        else
        {
            tr.Rotate(0, 0, -speed * Time.deltaTime);
            textSpeed.text = "Right";
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
