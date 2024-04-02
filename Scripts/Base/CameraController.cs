using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float smooth;
    private Vector3 playerPosition;

   
    void Start()
    {
        
    }

   
    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x,player.transform.position.y,transform.position.z);  

        
        transform.position = Vector3.Lerp(transform.position, playerPosition, smooth * Time.deltaTime);
    }
}
