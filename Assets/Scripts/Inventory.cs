using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject dogInventory;
    public GameObject guineaInventory;
    private int item;

    public void setInventory(int index)
    {
        item = index;
    }

    public void openInventory()
    {
        if (item == 0)
        {
            dogInventory.SetActive(!dogInventory.activeSelf);
            guineaInventory.SetActive(false);

        }
        else
        {
            dogInventory.SetActive(false);
            guineaInventory.SetActive(!guineaInventory.activeSelf);
        }
    }
}
