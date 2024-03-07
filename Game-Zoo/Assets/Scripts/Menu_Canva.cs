using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string NomeCena;
    public void LoadScenes()
    {
        SceneManager.LoadScene(NomeCena);
    }
}
