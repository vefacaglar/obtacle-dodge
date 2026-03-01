using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float speed = 1f;

    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var playerGameObject = GameObject.FindWithTag("Player");
        player = playerGameObject.transform;
        playerPosition = player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position != playerPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
            return;
        }
        Destroy(gameObject);
    }
}
