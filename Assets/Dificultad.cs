﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificultad : MonoBehaviour
{
    public int nivel_dificultad = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
