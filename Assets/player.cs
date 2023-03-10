using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    public float jumpForce = 680.0f;
   public float maxWalkSpeed = 2.0f;
   public float walkForce = 30.0f;
    public GameObject gamemaster;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("JumpTrigger");
            rigid2D.AddForce(transform.up * jumpForce);
        }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        float speedx = Mathf.Abs(rigid2D.velocity.x);
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        if (rigid2D.velocity.y == 0)
        {
            animator.speed = speedx / 2.0f; 
        }
        else
        {
            animator.speed = 1.0f;
        }
        
        
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "tak")
        {

            gamemaster.GetComponent<game>().HPhit();
        }
        if (collision.tag == "flag")
        {
            SceneManager.LoadScene("clear");

        }

    }
 }
