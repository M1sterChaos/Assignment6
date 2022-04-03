/*
 * (Austin Buck)
 * (Assignment 6)
 * (manages the inventory)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private InventoryItem item;

    public List<InventoryItem> inv;
    // Start is called before the first frame update
    void Start()
    {
        item = new InventoryItem();
        inv = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
