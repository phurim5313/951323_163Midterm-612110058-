﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoolDown : MonoBehaviour
{
    public float timeStart = 30;
    public Text textBox;
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
        if (timeStart<=0)
        {
           SceneManager.LoadScene("SceneMainmenu", LoadSceneMode.Single);
        }
    }
}
