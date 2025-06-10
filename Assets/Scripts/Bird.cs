using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;

    private float score;
    public Text scoreText;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
        }     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            Destroy(gameObject);
            scoreText.transform.position = new Vector3(0, 0, 0);
            scoreText.text = "Game Over\nScore: " + score.ToString();
            Time.timeScale = 0;
            restartButton.SetActive(true);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Count"))
        {
            score++;
            scoreText.text = score.ToString();

        }
    }
}
