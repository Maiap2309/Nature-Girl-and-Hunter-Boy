using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countries : MonoBehaviour
{
   public void Load(string name){
        SceneManager.LoadCountry(name);
    }

    public void Exit(){
        Application.Quit();
    }
 
}
