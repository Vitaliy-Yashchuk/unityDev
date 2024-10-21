using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour
{
    public GameObject cube;
    private Coroutine _coroutine;
    void Start()
    {
        //Invoke("CreateCube",2f);
        _coroutine=StartCoroutine(CreateCube());
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            StopCoroutine(_coroutine);
        }
    }
    IEnumerator CreateCube()
    {
        while (true)
        {
            Instantiate(cube, new Vector3(Random.Range(-6f,10f), Random.Range(3f,8f), Random.Range(-14f,30f)), Quaternion.identity);
            yield return new WaitForSecondsRealtime(2f);
        }
    }
  
}
