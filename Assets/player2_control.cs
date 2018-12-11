using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_control : MonoBehaviour
{
    private int player_speed = 15;
    private bool right = true;
    private float jump_power = 0.2f;
    private float moveX;
    public bool jumping;
    public GameObject player1;
    public bool grounded = false;
    public Vector3 current_checkpoint;
    public GameObject player_objects;
    public GameObject rope;
    private float off_x;
    private float off_y;
    private float rope_x;
    private float rope_y;
    public GameObject game_over_canvas;
    public GameObject game_over_text;

    private void Start()
    {
        off_x = this.gameObject.transform.position.x - player1.transform.position.x;
        off_y = this.gameObject.transform.position.y - player1.transform.position.y;
        rope_x = rope.transform.position.x - this.gameObject.transform.position.x;
        rope_y = rope.transform.position.y - this.gameObject.transform.position.y;
    }

    void Update()
    {
        float vel = this.GetComponent<Rigidbody2D>().velocity.y;

        if (vel <= 0.5f && vel >= -0.5f)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        player_movement();
    }

    void player_movement()
    {
        if (this.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0.1f)
        {
            jumping = true;
        }
        else
        {
            jumping = false;
        }
        moveX = Input.GetAxis("player2");
        if (Input.GetKeyDown("space") && grounded == true)
        {
            jump();
        }
        if (moveX < 0.0f && right == false)
        {
            flip_player();
        }
        else if (moveX > 0.0f && right == true)
        {
            flip_player();
        }
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * player_speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }


    void jump()
    {
        this.GetComponent<AudioSource>().Play();
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500f);
    }
    void flip_player()
    {
        right = !right;
        Vector2 local_scale = this.gameObject.transform.localScale;
        local_scale.x *= -1;
        transform.localScale = local_scale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "trap")
        {
            Globals.play2_defeat += 1;
            StartCoroutine("reset");
        }
    }

    IEnumerator reset()
    {
        game_over_canvas.SetActive(true);
        game_over_text.SetActive(true);
        yield return null;
    }
}
