using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour
{
    private Vector3 direction;
    private Vector3 endPosition;
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

        if (currentDuation >= durationTime || transform.position == endPosition)
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

    public void SetBullet(Vector3 startPosition, Vector3 direction)
    {
        speed = Random.Range(minSpeed, maxSpeed);

        endPosition = new Vector3(-startPosition.x, startPosition.y, -startPosition.z);
        this.direction = direction;

        currentDuation = 0;
        isReady = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().TakeDamage(1);
        }
    }
}
