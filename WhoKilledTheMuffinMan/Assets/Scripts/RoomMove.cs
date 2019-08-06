using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{

    public Vector2 cameraChange;
    public Vector2 playerChange;
    private CameraMovement cam;

    void Start()
    {
       // cam = Camera.Main.GetComponent<CameraMovement>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }

}
