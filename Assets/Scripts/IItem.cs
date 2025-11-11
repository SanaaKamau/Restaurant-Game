using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem
{


}
public interface ICraftable: IItem
{
    public bool CanCraft();
}
public interface IFood : ICraftable
{
    

}
public interface IIngredient: IItem
{

    
}
public interface IFurniture: ICraftable
{
    
    
}
