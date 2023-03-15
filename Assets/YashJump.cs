using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YashJump : MonoBehaviour
{
    public Rigidbody2D yash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            yash.velocity = new Vector2 (0, 5);
    }
}
