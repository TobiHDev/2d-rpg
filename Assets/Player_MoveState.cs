using UnityEngine;

public class Player_MoveState : EntityState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player_MoveState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName)
    {
    }
    public override void Update()
    {
        base.Update();
        if (player.mouseInput.x == 0)
        {
            stateMachine.ChangeState(player.idleState);
        }
    }

}
