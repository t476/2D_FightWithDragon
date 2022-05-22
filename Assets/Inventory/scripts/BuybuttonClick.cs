using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuybuttonClick : MonoBehaviour
{
    public Inventory bag;
    public MyItem sword;
    public MyItem gun;
    public MyItem air;
    public MyItem coffee;
   public void click()
    {
        int cost = 0;
        var curbtn = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        switch (curbtn.name)
        {
            case "buy_sword":
                if (sword.sold == false)
                {
                    bag.MyItemlist.Add(sword);
                    InventoryManager.CreatNewMyItem(sword);
                    cost = sword.MyItemPrice;//计算费用的方法。
                    sword.sold = true;
                }
                break;
            case "buy_gun":
                bag.MyItemlist.Add(gun);
                break;
            case "buy_airjacket":
                bag.MyItemlist.Add(air);
                break;
            case "coffee":
                bag.MyItemlist.Add(coffee);
                break;
        }
    }
}
