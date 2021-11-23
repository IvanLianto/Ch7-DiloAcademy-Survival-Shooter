using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" && !collision.isTrigger)
        {
            float enemyDistance = Vector3.Distance(transform.position, collision.transform.position);
            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}
