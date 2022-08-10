using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public string scene;

    public GameObject quitConfirm;

    public bool active;

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }

    public void SetActive()
    {
        quitConfirm.SetActive(active);
    }

    public void Opcoes()
    {
        if (quitConfirm.activeInHierarchy == true)
        {
            quitConfirm.SetActive(false);
            return;
        }

        quitConfirm.SetActive(true);
    }
}
