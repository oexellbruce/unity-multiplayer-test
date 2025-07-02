using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class playerController : NetworkBehaviour
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
        if (!IsOwner) return;
        Move();
    }

    void Move()
    {
        float frameSpeed = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))      { position.y += frameSpeed; }
        if (Input.GetKey(KeyCode.DownArrow))    { position.y -= frameSpeed; }
        if (Input.GetKey(KeyCode.LeftArrow))    { position.x -= frameSpeed; }
        if (Input.GetKey(KeyCode.RightArrow))   { position.x += frameSpeed; }

        player.transform.position = position;
    }
}
