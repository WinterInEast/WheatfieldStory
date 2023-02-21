using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WheatfieldStory.Inventory
{
    public class Item : MonoBehaviour
    {
        public int itemID;

        private SpriteRenderer spriteRenderer;

        private BoxCollider2D coll;

        private ItemDetails itemDetails;

        private void Awake()
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }

        private void Start()
        {
            if (itemID != 0)
            {
                Init(itemID);
            }
        }

        public void Init(int ID)
        {
            itemID = ID;

            itemDetails = InventoryManager.Instance.GetItemDetails(itemID);

            if (itemDetails != null)
            {
                spriteRenderer.sprite = itemDetails.itemOnWorldSprite != null ? itemDetails.itemOnWorldSprite : itemDetails.itemIcon;

                // Change the size and the offsize of collider according to the sprite size
                Vector2 newSize = new Vector2(spriteRenderer.sprite.bounds.size.x, spriteRenderer.sprite.bounds.size.y);
                coll.size = newSize;
                coll.offset = new Vector2(0, spriteRenderer.sprite.bounds.center.y);
            }
        }
    }
}
