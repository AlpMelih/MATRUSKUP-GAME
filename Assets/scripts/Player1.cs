using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public bool isMovable = true;
    public Rigidbody2D rb;
    Score Score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Score = GameObject.FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovable)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(-speed , rb.velocity.y);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(+speed , rb.velocity.y);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RedStar" || collision.gameObject.tag == "RainbowStar")
        {
            Destroy(collision.gameObject);
            Score.CollectStar();
            Score.CollectStarAudio.Play();
        }
    }

}
