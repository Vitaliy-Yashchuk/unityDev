using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public GameObject player;
    [NonSerialized]public bool _isCreated = false;
    private GameObject _playerCreated;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& !_isCreated)
        {
            _playerCreated = Instantiate(player, new Vector3(0, 5, 0), Quaternion.identity);
            
            _isCreated = true;
        }

        if (_playerCreated != null && Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Player deleted");
            Destroy(_playerCreated);
            
            
        }
    }
}
