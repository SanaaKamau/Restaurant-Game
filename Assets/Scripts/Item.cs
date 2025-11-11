using System;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string IconPath { get; set; }
    public string PrefabPath { get; set; }
}

[System.Serializable]
public class Food : Item, ICraftable
{
     public bool CanCraft()
    {
        bool craftable = false;
        return craftable;
    }


}
[System.Serializable]
public class Furniture : Item,ICraftable
{

    public bool CanCraft()
    {
        bool craftable = false;
        return craftable;
    }


}
[System.Serializable]
public class Ingredient : IIngredient
{


}
