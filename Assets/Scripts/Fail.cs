using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fail : MonoBehaviour
{
    public GameObject circle;
    public TextMeshProUGUI text;

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        text.text = "" + 0;
        circle.transform.position = new Vector2(0, 3);
        circle.GetComponent<Rigidbody2D>().velocity = Vector2.down;
    }
}
