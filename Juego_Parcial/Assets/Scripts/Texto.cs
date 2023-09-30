using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Texto : MonoBehaviour
{
    [SerializeField] private GameObject Nota;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Nota.SetActive(true);
        }

        else if (collision.tag == "Player"){
            Nota.SetActive(false);
        }
    }
}
