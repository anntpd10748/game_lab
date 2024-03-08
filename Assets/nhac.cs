using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doremi : MonoBehaviour
{
    AudioSource _do, _re, _mi;
    // Start is called before the first frame update
    void Start()
    {
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("do");
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("re");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("mi");
            _mi.Play();
        }
    }
}
