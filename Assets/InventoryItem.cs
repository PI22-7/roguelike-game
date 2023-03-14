using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InventoryItemTypes
{
    PURPLE,
    BLUE,
    Green,


}


public class InventoryItem {

    protected InventoryItemTypes type;

   public InventoryItem(InventoryItemTypes type)
    {
        this.type = type;
    }

   void Update() {

        // every potion has a random effect every time you run the game



        


    }




}
