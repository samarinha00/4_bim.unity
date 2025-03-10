using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaçãoPlayer : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private Rigidbody2D rigidbody;

    [SerializeField] private Player player;

    // Update is called once per frame
    void Update()
    {
        if (this.player.noChao) //está no chão
        {
            float velocidadeX = Mathf.Abs(this.rigidbody.velocity.x);
            if (velocidadeX > 0)
            {
                this.animator.SetBool("Andando", true);
            }
            else
            {
                this.animator.SetBool("Andando", false);
            }
            this.animator.SetBool("Jump", false);
            this.animator.SetBool("Fall", false);
        }
        else //não está no chão
        {
            float velocidadeY = this.rigidbody.velocity.y;
            if (velocidadeY > 0) //Subindo / Pulando
            {
                this.animator.SetBool("Jump", true);
                this.animator.SetBool("Fall", false);
            }
            else if (velocidadeY < 0) { //Caindo
                this.animator.SetBool("Jump", false);
                this.animator.SetBool("Fall", true);
            }
        }
    }
}