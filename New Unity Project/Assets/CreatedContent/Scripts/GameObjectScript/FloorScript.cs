﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloorScript : MonoBehaviour
{
    public int FloorNumber { get; set; }
    public EnemyScript EnemyScript { get; set; }
    public ContainerScript Container { get; set; }

    /// <summary>
    /// Remplit les valeurs du script
    /// </summary>
    /// <param name="floorNumber"></param>
    public void Initialize(int floorNumber)
    {
        this.FloorNumber = floorNumber;

        this.EnemyScript = ObjectFactory.CreateEnemy("trucmuche", 50, 25);
        this.Container = ObjectFactory.CreateContainer("oui", 10, null, null);
    }
}
