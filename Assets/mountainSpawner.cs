using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeInterval;
    public GameObject mountainPrefab;
    private float time = 0f;
    void Start()
    {
        spawnMountain();
        Debug.Log("In start method");
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (time < timeInterval)
        {
            time = time + Time.deltaTime;
        }
        else
        {
            spawnMountain();

            time = 0f;
        }
    }
    private void spawnMountain()
    {
        Instantiate(mountainPrefab, transform.position + Vector3.up * Random.Range(-3,3), transform.rotation);
    }
}