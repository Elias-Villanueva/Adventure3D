using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    
    public int ID;
    public string type;
    public string descripcion;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public bool equiped;

    private void Update() {
        if (equiped)
        {
            
        }
    }

    public void ItemUsage(){
        if (type == "Weapond")
        {
            
        }
    }
}
