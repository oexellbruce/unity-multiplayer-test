using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
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


        if (Input.GetKey(KeyCode.UpArrow))      { position.y += frameSpeed; }
        if (Input.GetKey(KeyCode.DownArrow))    { position.y -= frameSpeed; }
        if (Input.GetKey(KeyCode.LeftArrow))    { position.x -= frameSpeed; }
        if (Input.GetKey(KeyCode.RightArrow))   { position.x += frameSpeed; }

        player.transform.position = position;

    }
}
