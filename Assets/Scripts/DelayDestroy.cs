﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroy : MonoBehaviour
{
    private float lifeTime = 2.0f;
     public void Start() {
         Destroy(gameObject, lifeTime);
     }
}
