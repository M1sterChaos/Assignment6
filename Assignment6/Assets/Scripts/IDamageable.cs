/*
 * (Austin Buck)
 * (Assignment 6)
 * (Tells the player or enemy to take damage)
 */
using System.Collections;
using System.Collections.Generic;

public interface IDamageable
{
    void TakeDamage(int amount);
}
