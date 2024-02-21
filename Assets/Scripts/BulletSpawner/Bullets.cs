using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private Vector3 direction;
    private Rigidbody _rigidbody;

    private bool isReady;
    private float durationTime;
    private float currentDuation;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private float speed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        durationTime = 10f;
    }

    private void Update()
    {
        if (!isReady)
        {
            return;
        }

        currentDuation += Time.deltaTime;

        if(currentDuation >= durationTime)
        {
            DestroyBullet();
        }

        _rigidbody.velocity = direction * speed;
    }

    private void DestroyBullet()
    {
        gameObject.SetActive(false);
        isReady = false;
    }

    public void SetBullet(Vector3 startPosition, Vector3 targetPosition)
    {
        speed = Random.Range(minSpeed, maxSpeed);
        direction = Spread(startPosition, targetPosition);
        currentDuation = 0;
        isReady = true;
    }

    private Vector3 Spread(Vector3 startPosition, Vector3 targetPosition)
    {
        Vector3 start = startPosition;
        Vector3 target = targetPosition;

        target = new Vector3(target.x + Random.Range(-2, 2), target.y + Random.Range(-2, 2), target.z + Random.Range(-2, 2));

        return (target - start).normalized;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().TakeDamage(1);
        }

        if (!other.CompareTag("Bullet"))
        {
            DestroyBullet();
        }
    }
}
