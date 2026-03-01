using System.Linq;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject[] projectilePrefab;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered: " + projectilePrefab.Count());
        if (other.CompareTag("Player"))
        {
            foreach (var projectile in projectilePrefab)
            {
                projectile.SetActive(true);
            }
        }
    }
}
