using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lib;

public class GameManager : Singleton<GameManager>
{
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Star1.SetActive(false);
        Star2.SetActive(false);
        Star3.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Star")
        {

            
            other.gameObject.SetActive(false);//충돌시 오브젝트 비활성화

            count += 1;
            Debug.Log(count);

        }
        switch (count)
        {
            case 1:
                Star1.SetActive(true);
                break;
            case 2:
                Star2.SetActive(true);
                break;
            case 3:
                Star3.SetActive(true);
                break;
        }

    }

    void end()
    {

    }

}
