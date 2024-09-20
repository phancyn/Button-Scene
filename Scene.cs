using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI

public class Scene : MonoBehaviour
{
    //Панель настроек
    public GameObject Panel;
    // Для другого
    public GameObject Panel1;
    
    public void loadScene(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }


    //Открытие настроек, активация панель из UI Unity 
    public void openSettings()
    {
        Panel.SetActive(true);
    }

    
    public void closeSettings()
    {
        Panel.SetActive(false);
    }

    public void closeGame()
    {
        Application.Quit(); // закрыть приложение 
    }
    
    
    
}
