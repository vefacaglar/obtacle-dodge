using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 1f;

    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != playerPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
            return;
        }
        Destroy(gameObject);
    }
}
