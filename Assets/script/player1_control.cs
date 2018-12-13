using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1_control : MonoBehaviour {
    private int player_speed = 30;
    private bool right = true;
    private float jump_power = 100f;
    private float moveX;
    public bool grounded = false;
    public GameObject player2;
    public GameObject game_over_canvas;
    public GameObject game_over_text;
    void Update()
    {
        float vel = this.GetComponent<Rigidbody2D>().velocity.y;

        if (vel<=0.5f&&vel>=-0.5f)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        if (enabled)
        {
            player_movement();
        }
    }
    private void Start()
    {
        enabled = true;
    }

    void player_movement()
    {
        moveX = Input.GetAxis("player1");
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded == true)
        {
            jump();
        }

        if(moveX<0.0f &&right == false)
        {
            flip_player();
        }
        else if(moveX>0.0f && right == true)
        {
            flip_player();
        }
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * player_speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        this.GetComponent<Animator>().SetBool("Walk", true);
    }

    
    void jump()
    {
        this.GetComponent<AudioSource>().Play();
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200f);
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
            enabled = false;
            player2.GetComponent<player2_control>().enabled = false;
            StartCoroutine("reset");
        }
    }

    IEnumerator reset()
    {
        Globals.play1_defeat += 1;
        game_over_canvas.SetActive(true);
        game_over_text.SetActive(true);
        //SceneManager.LoadScene("main");
        yield return null;
    }
}
