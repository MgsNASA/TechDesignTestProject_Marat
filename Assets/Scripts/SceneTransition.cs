using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad; // ������� ��� ������ ����� ��� ��������

    public void LoadScene( )
    {
        SceneManager.LoadScene ( sceneToLoad );
        Debug.Log ( "ASSAd" );
    }
}
