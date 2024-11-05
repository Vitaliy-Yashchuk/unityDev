using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator _animator;
    private float speed = 5f, rotateSpeed = 0.3f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        // Ротування персонажа залежить від горизонтального вводу
        transform.Rotate(Vector3.up * rotateSpeed * Input.GetAxis("Horizontal"));
    }

    private void MovePlayer()
    {
        // Отримуємо вертикальний ввід
        verticalInput = Input.GetAxis("Vertical");

        if (verticalInput != 0)
        {
            // Рухаємо персонажа
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
            // Установлюємо параметр "IsWalking" в true, коли персонаж рухається
            _animator.SetBool("IsWalking", true);
            Debug.Log("IsWalking: true");  // Вивести в консоль, коли персонаж рухається
        }
        else
        {
            // Якщо ввід відсутній (персонаж не рухається)
            _animator.SetBool("IsWalking", false);
            Debug.Log("IsWalking: false");  // Вивести в консоль, коли персонаж не рухається
        }
    }

}