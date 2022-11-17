using Godot;
using System;

public partial class TempNode : Node
{
    //method rolling dice animation and sound
    public void RollDice()
    {
        //roll dice animation
        var rollDice = GetNode<AnimationPlayer>("RollDice");
        rollDice.Play("RollDice");
     
    }
    

}
