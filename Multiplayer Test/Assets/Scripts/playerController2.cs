using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController2 : MonoBehaviour
{

    public float speed = 1f;
    public GameObject player;

    private Vector2 position = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float frameSpeed = speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.W))    { position.y += frameSpeed; }
        if (Input.GetKey(KeyCode.S))    { position.y -= frameSpeed; }
        if (Input.GetKey(KeyCode.A))    { position.x -= frameSpeed; }
        if (Input.GetKey(KeyCode.D))    { position.x += frameSpeed; }

        player.transform.position = position;

    }
}
