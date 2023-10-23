using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlatesCounter : BaseCounter
{
    public event EventHandler OnPlateSpawned;

    [SerializeField] private KitchenObjectSO plateKitchenObjectSO;
    private float spawnPlateTimer;
    private float spawnPlateTimerMax = 4f;
    private int platesSpawnedAmmount;
    private int platesSpawnedAmmountMax = 4;

    private void Update()
    {
        spawnPlateTimer += Time.deltaTime;
        if (spawnPlateTimer>spawnPlateTimerMax)
        {
            spawnPlateTimer = 0f;
            if (platesSpawnedAmmount<platesSpawnedAmmountMax)
            {
                platesSpawnedAmmount++;
            }
        }
    }

}
