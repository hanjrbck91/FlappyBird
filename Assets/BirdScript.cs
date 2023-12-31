using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2d;
    public float flapStrength;
    [HideInInspector] public LogicScript logic;
    [SerializeField] private Animator animator;

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        animator.enabled = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    } 

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody2d.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        Invoke("PauseGame", 2);
        var animator = gameObject.GetComponent<Animator>();
        animator.enabled = false;


    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
