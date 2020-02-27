using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Movement.score += 10;
        Destroy(gameObject);
    }
}
