using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainMover : MonoBehaviour
{
    // Start is called before the first frame update
    public float momentSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * momentSpeed;
        if (transform.position.x < -12)
            Destroy(gameObject);
    }
}
