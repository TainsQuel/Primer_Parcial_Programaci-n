using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
  public void Escena1()
    {
        SceneManager.LoadScene(2);
    }

    public void Escena2()
    {
        SceneManager.LoadScene(3);
    }

    public void Salir()
    {
        Debug.Log("Saliste");
        Application.Quit();
    }
}
