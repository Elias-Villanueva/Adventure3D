using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int enabledSlots;
    public GameObject[] slot;
    public GameObject slotHolder;
    
    void Start()
    {
        allSlots = slotHolder.transform.childCount;

        slot = new GameObject[allSlots];

        for (var i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;

        }
        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }else
        {
            inventory.SetActive(false);
        }    
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Item")
            {
                GameObject itemPickedUp = other.gameObject;

                Item item = itemPickedUp.GetComponent<Item>();

                AddItem(itemPickedUp,item.ID, item.type, item.descripcion, item.icon);
            }
    }

    public void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescripcion, Sprite itemIcon)
    {
        for (var i = 0; i < allSlots; i++)
        {
            if (slot[i].GetComponent<Slot>().empty)
            {
                itemObject.GetComponent<Item>().pickedUp = true;

                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().descripcion = itemDescripcion;
                slot[i].GetComponent<Slot>().icon = itemIcon;

                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();

                slot[i].GetComponent<Slot>().empty = false;
            }
            return;
        }
    }

}
