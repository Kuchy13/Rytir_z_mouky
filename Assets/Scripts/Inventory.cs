using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryUI;
    public static bool isInventoryOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isInventoryOpen)
            {
                CloseInventory();
            }
            else
            {
                OpenInventory();
            }
        }
    }

    public void OpenInventory()
    {
        inventoryUI.SetActive(true);
        isInventoryOpen = true;
    }

    public void CloseInventory()
    {
        inventoryUI.SetActive(false);
        isInventoryOpen = false;
    }
}