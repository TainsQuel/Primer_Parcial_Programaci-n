using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
  public void Escena1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void Escena2()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void Salir()
    {
        Debug.Log("Saliste");
        Application.Quit();
    }
}
