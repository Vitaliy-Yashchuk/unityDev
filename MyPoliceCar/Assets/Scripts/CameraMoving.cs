
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    private GameObject player;
    public Vector3 offset;
    void Update()
    {
        if(player == null)
            player = GameObject.Find("Player(Clone)");
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
