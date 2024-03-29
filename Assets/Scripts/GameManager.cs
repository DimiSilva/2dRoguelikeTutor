﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public BoardManager BoardScript;

    public int level = 3;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        BoardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame(){
        BoardScript.SetupScene(level);
    }

    void Update()
    {
        
    }
}