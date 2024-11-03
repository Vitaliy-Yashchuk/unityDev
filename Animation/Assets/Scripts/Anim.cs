using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private Animation _anim;
    void Start()
    {
        _anim = GetComponent<Animation>();
        _anim.Play();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P) && !_anim.isPlaying)
        {
            _anim.Play();
        }
        if (Input.GetKeyUp(KeyCode.S) && _anim.isPlaying)
        {
            _anim.Stop();
        }
    }

    void DisplayInfo()
    {
        Debug.LogWarning("Key frame from animation");
    }

}
