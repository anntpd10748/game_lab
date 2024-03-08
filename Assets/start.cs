using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("ban nhap phim A");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("ban nhap phim B");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("ban nhap phim C");
        }
    }
}
