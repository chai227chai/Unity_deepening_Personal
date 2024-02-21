using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LaserDirection
{
    LtR,
    RtL,
    UtD,
    DtU
}

public class LaserSpawner : MonoBehaviour
{
    [SerializeField] private ObjectPool bulletPool;

    public LaserDirection laserDirection;

    private Vector3 direction;

    private void Start()
    {
        switch (laserDirection)
        {
            case LaserDirection.LtR:
                direction = Vector3.right;
                break;
            case LaserDirection.RtL:
                direction = Vector3.left;
                break;
            case LaserDirection.UtD:
                direction = Vector3.back;
                break;
            case LaserDirection.DtU:
                direction = Vector3.forward;
                break;
        }
    }

    public void ShootLaser()
    {
        GameObject obj;
        if (laserDirection == LaserDirection.LtR || laserDirection == LaserDirection.RtL)
        {
            obj = bulletPool.SpawnObject("Laser_Vertical");
        }
        else
        {
            obj = bulletPool.SpawnObject("Laser_Horizontal");
        }

        obj.transform.position = transform.position;

        Lasers laser = obj.GetComponent<Lasers>();
        laser.SetBullet(transform.position, direction);

        obj.SetActive(true);
    }
}
