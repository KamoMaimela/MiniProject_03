using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator Anim;
    public string sceneName;


    public void Play()
    {
        
        StartCoroutine(LoadScene());

    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        Anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }

    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }


}

