using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform player = GameObject.FindWithTag("Player").transform;

    Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
    Vector2 playerPosition = new Vector2(player.position.x, player.position.y);


    public MonsterState currentState = MonsterState.Idle;
    private enum MonsterState
    {
        Idle,
        Move,
        Attak
    }
    private State _state;

    private void Start()
    {

    }

    private void Update()
    {
        switch (currentState)
        {
            case MonsterState.Idle:
                break;

            case MonsterState.Move:
                break;

            case MonsterState.Attak:
                break;
        }
    }

    private void Think()
    {

    }
}