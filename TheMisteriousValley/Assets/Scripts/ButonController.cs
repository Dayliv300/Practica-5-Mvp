using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuInicio");
    }

    // Update is called once per frame
    public void Salir()
    {
        Application.Quit();
    }
}
