using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private Button button;

    private void Awake()
    {

        button.onClick.AddListener(NextScene);
    }

    private void NextScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
