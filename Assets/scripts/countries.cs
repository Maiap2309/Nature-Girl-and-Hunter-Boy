﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countries : MonoBehaviour
{
    public void LoadUSALevel() {
        SceneManager.LoadScene("Master scene");
    }

    public void goToMainMenu() {
        SceneManager.LoadScene("Menu");
    }
   
}
