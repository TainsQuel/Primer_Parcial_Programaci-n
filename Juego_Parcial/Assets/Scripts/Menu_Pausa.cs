using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject MenuPausa;
    public void Pause()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false) ;
        MenuPausa.SetActive(true) ;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        MenuPausa.SetActive(false);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
