using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countries : MonoBehaviour
{
<<<<<<< HEAD
   public void Load(string name){
        SceneManager.LoadScene(name);
=======
    public void LoadUSALevel() {
        SceneManager.LoadScene("Master scene");
>>>>>>> 5c017d3f21dacd40699246676cd321173477e40b
    }

    public void goToMainMenu() {
        SceneManager.LoadScene("Menu");
    }
   
}
