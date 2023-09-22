using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Rigidbody2D Rigid;

    public float Velocidad;

    private Animator animaciones;

    private SpriteRenderer Flip;


    private void Awake()
    {
        Rigid = GetComponent<Rigidbody2D>();
        animaciones = GetComponentInChildren<Animator>();
        Flip = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector2 direccion = new Vector2(hori, verti);


        Rigid.velocity = direccion.normalized * Velocidad;

        animaciones.SetFloat("Walk_Hori", Mathf.Abs(Rigid.velocity.x));
        animaciones.SetFloat("Walk_Vert", (Rigid.velocity.y));

        if (hori > 0 ){
            Flip.flipX = false;
        }

        else if(hori < 0){
            Flip.flipX = true;
        }
    }
}
