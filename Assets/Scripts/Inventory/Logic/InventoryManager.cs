using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WheatfieldStory.Inventory
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        public ItemDataList_SO itemDataList_SO;

        /// <summary>
        /// Get itme details through ID
        /// </summary>
        /// <param name="ID">Item ID</param>
        /// <returns></returns>
        public ItemDetails GetItemDetails(int ID)
        {
            return itemDataList_SO.itemDetailsList.Find(i => i.itemID == ID);
        }
    }
}


