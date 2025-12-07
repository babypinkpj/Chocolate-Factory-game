using UnityEngine;
using System;

public class MoveCommand : ICommand
{
    private BasketControllerScript _basket;
    private float _direction;

    public MoveCommand(BasketControllerScript basket, float direction)
    {
        _basket = basket;
        _direction = direction;
    }

    public void Execute()
    {
        _basket.MoveBasket(_direction);
    }

    public void Undo()
    {
        _basket.MoveBasket(-_direction);
    }
}

public class RotateCommand : ICommand
{
    private BasketControllerScript _basket;
    private float _direction;

    public RotateCommand(BasketControllerScript basket, float direction)
    {
        _basket = basket;
        _direction = direction;
    }

    public void Execute()
    {
        _basket.RotateBasket(_direction);
    }

    public void Undo()
    {
        _basket.RotateBasket(-_direction);
    }
}