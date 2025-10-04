using UnityEngine;

public abstract class EntityState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   protected StateMachine stateMachine;
   protected Player player;
   protected string stateName;

    public EntityState(Player player, StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.player = player;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        Debug.Log("Entering state: " + stateName);
     }

    public virtual void Exit()
    {
        Debug.Log("Exiting state: " + stateName);
    }

    public virtual void Update()
    {
        Debug.Log("Updating state: " + stateName);
    }

}
