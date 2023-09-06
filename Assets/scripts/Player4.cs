using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;
    public float jump;
    public bool isMovable = true;
    public Rigidbody2D rb;
    public Rigidbody2D rb2;
    public GameObject Player3Prefab;
    public Transform SpawnPoint;
    GameObject Player3;
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
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(+speed, rb.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Player3 = Instantiate(Player3Prefab, SpawnPoint.transform.position, Quaternion.identity);
                rb2 = Player3.GetComponent<Rigidbody2D>();
                rb2.AddForce(SpawnPoint.up * jump, ForceMode2D.Impulse);
                isMovable = false;
                rb.mass = 100;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GreenStar" || collision.gameObject.tag == "RainbowStar")
        {
            Destroy(collision.gameObject);
            Score.CollectStar();
            Score.CollectStarAudio.Play();
        }
    }
}