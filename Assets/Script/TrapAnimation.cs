using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public PlayerMovement playerMovement;
    public int TrapDamage;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetBool("isActive", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("isActive", false);

    }

    public void PlayerDamage()
    {
        playerMovement.healthpoints = playerMovement.healthpoints - TrapDamage;
;
    }
}
