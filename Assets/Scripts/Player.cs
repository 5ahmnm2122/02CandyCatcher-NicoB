using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    int score = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CanvasManager.Instance.score.text = score.ToString();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(20 * Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-20 * Vector2.left);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Candy")
        {
            score = collision.GetComponent<SpriteRenderer>().color == Color.black ? score -= 1 : score += 1;
            try
            {
                CanvasManager.Instance.score.text = score.ToString();
                StatsManager.Instance.score = score;
                if (score <= -5)
                {
                    SceneManager.Instance.PendLoadScene(2);
                }

            }
            catch (System.Exception)
            {
                Debug.LogWarning("Start in first scene!");
            }
            Destroy(collision.gameObject);
        }
    }
}
