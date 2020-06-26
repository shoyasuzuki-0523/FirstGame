﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDataBase : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();
    private int ItemCount = 0;

   void Start()
    {
        setItem(new Item(0,"サンプル鍵","これはテスト用の鍵です。",Item.ItemType.Key));
        setItem(new Item(1,"サンプル資料","これはテスト用の資料です。",Item.ItemType.Document));
    }

    public List<Item> getItemList(){
        return items;
    }

    public Item getItem(int i){
        return items[i];
    }

    public int getItemCount(){
        return ItemCount;
    }

    public void setItem(Item i){
        items.Add(i);
        ItemCount ++;
    }
}