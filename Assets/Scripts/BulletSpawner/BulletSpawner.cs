using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private ObjectPool bulletPool;

    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;
    private float bulletSpawnTime;
    private string targetTag;

    private void Awake()
    {
        targetTag = "Player";
    }

    private void Start()
    {
        bulletSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);

        GameManager.instance.GameStart += InvokeShooting;
    }

    public void InvokeShooting()
    {
        InvokeRepeating("ShootBullet", bulletSpawnTime, bulletSpawnTime);
    }

    public void ShootBullet()
    {
        Vector3 target = GameObject.FindGameObjectWithTag(targetTag).transform.position;
        GameObject obj = bulletPool.SpawnObject("Bullet");

        obj.transform.position = transform.position;

        Bullets bullet = obj.GetComponent<Bullets>();
        bullet.SetBullet(transform.position, target);

        obj.SetActive(true);

        bulletSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
