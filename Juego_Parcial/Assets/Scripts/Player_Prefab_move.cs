using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Prefab_move: MonoBehaviour
{
    private Rigidbody2D Rigid;

    public float Velocidad;

    private void Awake()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector2 direccion = new Vector2(hori, verti);
        Rigid.velocity = direccion.normalized * Velocidad;
        }
    }
