﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScene()
    {
          SceneManager.LoadScene("Cargando");
    }
    public void QuitGame()
    {
          Debug.Log("QUIT!");
          Application.Quit();
    }

}
