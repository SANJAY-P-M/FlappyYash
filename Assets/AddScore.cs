using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    void Start()
    {
        score = GameObject.FindAnyObjectByType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.text = (int.Parse(score.text) + 1).ToString();
        Debug.Log(score.text);
    }
}
