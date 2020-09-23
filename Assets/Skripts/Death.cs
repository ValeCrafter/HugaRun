using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public GameObject player;
    private Vector2 velocity;



    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(velocity);
    }
}
