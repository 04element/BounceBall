using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 3;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);//가운데에서 시작!
    }

    void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.y > 1f) pos.y = 1f; 

        transform.position = Camera.main.ViewportToWorldPoint(pos);//위로 못 빠져 나가게하기

        if (Input.GetKey("left")||Input.GetKey("a"))
        {
            transform.Translate(speed*-Time.deltaTime,0,0);
        }
        if (Input.GetKey("right")||Input.GetKey("d"))
        {
            transform.Translate(speed*Time.deltaTime,0,0);

        }
    }
}
