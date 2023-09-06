using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jump;
    public float speed;
    public bool isMovable=true;
    public Rigidbody2D rb;
    public Rigidbody2D rb2;
    public GameObject Player4Prefab;
    public Transform SpawnPoint;
    GameObject Player4;
    public float gravity=1;
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
        if (isMovable) { 
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(-speed , rb.velocity.y);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(+speed , rb.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
               Player4= Instantiate(Player4Prefab,SpawnPoint.transform.position, Quaternion.identity); 
                rb2 = Player4.GetComponent<Rigidbody2D>();
                rb2.AddForce(SpawnPoint.up*jump,ForceMode2D.Impulse);
                isMovable = false;
                rb.mass = 100;
            }
        }   
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "OrangeStar" || collision.gameObject.tag == "RainbowStar")
        {
            Destroy(collision.gameObject);
            Score.CollectStar();
            Debug.Log("ÇARPIÞMA");
            Score.CollectStarAudio.Play();
        }
    }
}
