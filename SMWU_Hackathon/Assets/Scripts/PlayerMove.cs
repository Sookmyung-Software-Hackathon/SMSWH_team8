using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{

    public float maxSpeed;
    public float jumpPower;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;
    GameObject scanObject;
    int direction;
    float detect_range = 1.0f;
    public int booinCount; 

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        moving();
        
    }


    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1))
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);


        landing();

        Debug.DrawRay(rigid.position, new Vector3(direction * detect_range, 0, 0));

        RaycastHit2D rayHit_detect = Physics2D.Raycast(rigid.position, new Vector3(direction, 0, 0), detect_range, LayerMask.GetMask("Object"));

        if (rayHit_detect.collider != null)
        {
            scanObject = rayHit_detect.collider.gameObject;
            Debug.Log(scanObject.name);
        }
        else
        {
            scanObject = null; 
        }
        /*
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("StartScene"));
        Debug.DrawRay(rigid.position, Vector3.down, new Color(1, 1, 0));
        if (rayHit_detect.collider != null)
        {
            scanObject = rayHit_detect.collider.gameObject;
            Debug.Log(scanObject.name);
        }
        else
        {
            scanObject = null;
        }
        */
    }





    void landing()
    {
        if (rigid.velocity.y < 0)
        {
            
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 1.0f)
                    anim.SetBool("isJumping", false);
            }
        }
    }

    void moving()
    {
        //오브젝트 스캔
        if (Input.GetMouseButtonDown(0) && scanObject != null)
        {
            Debug.Log(scanObject.name);
            GameManager.Instance.Action(scanObject);
        }

        if (SceneManager.GetActiveScene().name == "Chapter1-3")
        {
            Debug.DrawRay(rigid.position, new Vector3(direction * detect_range, 0, 0));
            RaycastHit2D rayHit_detect2 = Physics2D.Raycast(rigid.position, new Vector3(direction, 0, 0), detect_range, LayerMask.GetMask("Boo"));
            if (rayHit_detect2.collider != null&& Input.GetMouseButtonDown(0))
            {
                Debug.Log("부인");
                scanObject = rayHit_detect2.collider.gameObject;
                GameManager.Instance.Action(scanObject);
                booinCount += 1;
                return;
            }
        }

        if (Input.GetButtonDown("Jump") && !anim.GetBool("isJumping"))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }


        if (Input.GetButton("Horizontal"))
        {
            if (Input.GetAxisRaw("Horizontal")==-1)
            {
                spriteRenderer.flipX = true;
                direction = -1; 
            }
            else
            {
                spriteRenderer.flipX = false;
                direction = 1; 
            }
        }
        /*
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }

        if (Input.GetButton("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }
        */
        if (rigid.velocity.normalized.x == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }
    }


}