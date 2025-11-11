using System;

public class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string IconPath { get; set; }
    public string PrefabPath { get; set; }
}
[System.Serializable]
public class RecipeIngredient
{
    public int IngredientID; 
    public int Quantity;      
}

[System.Serializable]
public class Recipe : Item, IFood
{
    public RecipeIngredient ingredients; 
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
