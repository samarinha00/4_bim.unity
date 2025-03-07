using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaçãoPlayer : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField] 
    private Rigidbody2D rigidbody;
    
    
    // Update is called once per frame
    void Update()
    {
        float velocidadeX = Mathf.Abs(this.rigidbody.velocity.x);
        if (velocidadeX > 0) {
            this.animator.SetBool("correndo", true);
        }
        else
        {
            this.animator.SetBool("correndo", false);
        }
    }
}
