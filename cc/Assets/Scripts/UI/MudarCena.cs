using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public string scene;

    public GameObject quitConfirm;

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void QuitConfirm()
    {
        if (quitConfirm.activeInHierarchy == false)
        {
            quitConfirm.SetActive(true);
        }
        else
        {
            quitConfirm.SetActive(false);
        }
    }
}
