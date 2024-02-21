using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    [SerializeField] private LaserSpawner[] laserSpawners;

    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;
    private float laserSpawnTime;

    private void Start()
    {
        laserSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);

        GameManager.instance.GameStart += InvokeShooting;
    }

    public void InvokeShooting()
    {
        InvokeRepeating("ShootBullet", laserSpawnTime, laserSpawnTime);
    }

    public void ShootBullet()
    {
        laserSpawners[Random.Range(0, laserSpawners.Length - 1)].ShootLaser();
    }

}
