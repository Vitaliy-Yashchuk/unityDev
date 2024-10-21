using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private MeshRenderer _mesh;
    public float speed = 5f, horSpeed = 3f;
    private Rigidbody _rb;
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    void Awake()
    {
        _mesh = gameObject.GetComponent<MeshRenderer>();
        _rb = gameObject.GetComponent<Rigidbody>();
        light1 = GameObject.Find("Light1")?.GetComponent<Light>();
        light2 = GameObject.Find("Light2")?.GetComponent<Light>();
        light3 = GameObject.Find("Light3")?.GetComponent<Light>();
        light4 = GameObject.Find("Light4")?.GetComponent<Light>();

    }

    void Start()
    {
        if (light1 != null) light1.enabled = false;
        if (light2 != null) light2.enabled = false;
        if (light3 != null) light3.enabled = false;
        if (light4 != null) light4.enabled = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (light1 != null) light1.enabled = true;
            if (light2 != null) light2.enabled = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (light3 != null) light3.enabled = true;
            if (light4 != null) light4.enabled = true;
        }
        else
        {
            if (light1 != null) light1.enabled = false;
            if (light2 != null) light2.enabled = false;
            if (light3 != null) light3.enabled = false;
            if (light4 != null) light4.enabled = false;
        }

        float horMove = Input.GetAxis("Horizontal");
        float vertMove = Input.GetAxis("Vertical");
        
        transform.Rotate(horMove * Vector3.up * horSpeed * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, vertMove * speed * Time.deltaTime));
    }

    void OnDestroy()
    {
        GameObject obj = GameObject.Find("Ground");
        if (obj != null)
        {
            obj.GetComponent<CreatePlayer>()._isCreated = false;
        }
    }
}