using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
    [SerializeField]
    private UIManager uiManager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public int Score
    {
        get { return PlayerPrefs.GetInt("score", 100000); }
        set { PlayerPrefs.SetInt("score", value); }
    }
}


