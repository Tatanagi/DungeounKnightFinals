using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float moveSpeed;
    public Vector2 movementInput;
    public Rigidbody2D rigidBody;
    public Animator anim;
    public TextMeshProUGUI healthcounter, coinsCounter;
    public int healthpoints, coinpoints;
    public int PlayerisInTop;
    public int value;
    




    void Start()
    {

        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
   

    // Update is called once per frame
    void Update()
    {

        anim.SetFloat("Horizontal", movementInput.x);
        anim.SetFloat("Vertical", movementInput.y);
        anim.SetFloat("Speed", movementInput.sqrMagnitude);
        
        healthcounter.text = healthpoints.ToString();
        coinsCounter.text = coinpoints.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coins")) 
        {
            coinpoints++;
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("SonicCoin"))
        {
            healthpoints = 200; 
            Destroy(collision.gameObject);
        }
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }

   







}  