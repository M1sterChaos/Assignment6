/*
 * (Austin Buck)
 * (Assignment 6)
 * (Super class for the weapon type)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    public void Recharge()
    {
        Debug.Log("Recharging weapon!");
    }

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
