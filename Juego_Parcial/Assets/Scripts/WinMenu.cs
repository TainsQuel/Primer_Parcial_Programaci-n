using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void Volver()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
