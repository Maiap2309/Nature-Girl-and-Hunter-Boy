using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countries : MonoBehaviour
{

    public void Load(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void LoadUSALevel() {
        SceneManager.LoadScene("Master scene");

    }

    public void LoadItalyLevel() {
        SceneManager.LoadScene("Italy");

    }


    public void LoadChinaLevel() {
        SceneManager.LoadScene("China");

    }

    public void LoadCanadaLevel() {
        SceneManager.LoadScene("Canada");

    }


    public void LoadBrazilLevel() {
        SceneManager.LoadScene("Brazil");

    }


    public void LoadJapanLevel() {
        SceneManager.LoadScene("Japan");

    }


    public void LoadIndiaLevel() {
        SceneManager.LoadScene("India");

    }

    public void goToMainMenu() {
        SceneManager.LoadScene("Menu");
    }
   
}
