using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyCurrenHealth;
    public int enemyMaxHealth;

    private void Start()
    {
        enemyCurrenHealth = enemyMaxHealth;
    }

    void Update()
    {
        
    }
}
