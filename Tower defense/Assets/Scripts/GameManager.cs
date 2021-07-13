using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float currenGameHealth;
    public float gameHealth = 100;

    public float speed;

    public RectTransform hitpointBar;

    void Start()
    {
        currenGameHealth = gameHealth;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Space");
            ReceiveDamage(20);
        }
    }

    private void ReceiveDamage(int damage)
    {
        currenGameHealth -= damage;
        OnHitpointChange();        
    }

    public void OnHitpointChange()
    {
        float ratio = (float)currenGameHealth / (float)gameHealth;
        hitpointBar.localScale = new Vector3(ratio, 1, 1);
    }
}
