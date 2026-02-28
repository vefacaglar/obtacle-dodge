using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hit = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hit++;
            Debug.Log("Hit: " + hit);
        }

    }
}
