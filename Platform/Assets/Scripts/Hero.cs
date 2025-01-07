using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.VersionControl.Asset;


public class Hero : Entity
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForse = 15f;
    public static Hero Instance { get;set; }
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private bool isgrounded = false;

    private void Start()
    {
        lives = 5;
    }
    public void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Run()
    {
        if (isgrounded) state = States.run_animation;
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position=Vector3.MoveTowards(transform.position, transform.position+dir, speed*Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }
    
    private void Jump ()
    {
        rb.AddForce(transform.up * jumpForse, ForceMode2D.Impulse);
    }
    private void checkground()
    {
        if (!isgrounded) state = States.jump;
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isgrounded=collider.Length > 1;
    }
    private void FixedUpdate()
    {
        checkground();
    }

    private void Update()
    {
        if (isgrounded) state = States.Default;
        
        if (Input.GetButton("Horizontal"))
        Run();
        if (isgrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    public enum States
    {
        Default,
        run_animation,
        jump
    }
    private States state
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Coin")) return;
        {
            coinnumber++;
            Debug.Log("Монет на рахунку " + coinnumber);
            Destroy(other.gameObject);
        }
    }
}
