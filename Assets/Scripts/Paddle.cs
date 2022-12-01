using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D circleBody;
    public TextMeshProUGUI text;

    void Update()
    {
        float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        transform.position = new Vector2(x, transform.position.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name == "Circle")
            text.text = "" + int.Parse(text.text) + 1;

        circleBody.AddForce(new Vector2(0, 20));
    }
}
