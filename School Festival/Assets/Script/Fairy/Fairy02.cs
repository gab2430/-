using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy02 : MonoBehaviour
{
    private Vector2 fairyPos;
    public float A = 1.0f;
    public float B = 4.0f;

    private void Start()
    {
        fairyPos = transform.position;
    }
    private void Update()
    {
        transform.position = new Vector2(Mathf.Sin(A * Time.time) * 40.0f + fairyPos.x,Mathf.Cos(B * Time.time) * 1.0f + fairyPos.y);
    }


}
