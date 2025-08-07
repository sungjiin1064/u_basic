using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBottonContainer : MonoBehaviour
{
    public void ButtonRestart()
    {
        Debug.Log("����۹�ư");
        SceneManager.LoadScene(1);
    }
    public void ButtonHome()
    {
        Debug.Log("���θ޴� ��ư");
        SceneManager.LoadScene(0);
    }

    public void ButtonExit()
    {
        Debug.Log("�������� ��ư");
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif 
    }

    public void ButtonNext(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
