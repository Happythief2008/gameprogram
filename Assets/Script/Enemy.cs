using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    private Vector2 currentPosition;
    private Vector2 playerPosition;

    public MonsterState currentState = MonsterState.Idle;

    public enum MonsterState
    {
        Idle,
        Move,
        Attack
    }

    private void Start()
    {
        // 플레이어 태그로 찾아서 참조할 때 null check 추가
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }

        // 초기 위치 설정
        currentPosition = new Vector2(transform.position.x, transform.position.y);
        if (player != null)
        {
            playerPosition = new Vector2(player.position.x, player.position.y);
        }
    }

    private void Update()
    {
        switch (currentState)
        {
            case MonsterState.Idle:
                // Idle 상태에서는 아무 동작도 하지 않음
                break;

            case MonsterState.Move:
                // Move 상태에서는 플레이어를 향해 이동
                if (player != null)
                {
                    currentPosition = new Vector2(transform.position.x, transform.position.y);
                    playerPosition = new Vector2(player.position.x, player.position.y);

                    float step = 2f * Time.deltaTime;
                    transform.position = Vector2.MoveTowards(currentPosition, playerPosition, step);
                }
                break;

            case MonsterState.Attack:
                // Attack 상태에서는 아직 동작 없음
                break;
        }
    }
}
