using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonContainer : MonoBehaviour
{
    public void ButtonStart()
    {
        Debug.Log("������ �����մϴ�.");

        SceneManager.LoadScene(1);
    }
    public void ButtonTutorial(GameObject tut)
    {
        Debug.Log("Ʃ�丮���� �����մϴ�.");

        tut.SetActive(true);
    }
    public void ButtonOption(GameObject opt)
    {
        Debug.Log("�ɼ� ��ư�� Ȱ��ȭ�˴ϴ�.");

        opt.SetActive(true);
    }
    public void ButtonExit()
    {
        Debug.Log("������ �����մϴ�.");

        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif 
    }
}
