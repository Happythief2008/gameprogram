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
        // �÷��̾� �±׷� ã�Ƽ� ������ �� null check �߰�
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }

        // �ʱ� ��ġ ����
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
                // Idle ���¿����� �ƹ� ���۵� ���� ����
                break;

            case MonsterState.Move:
                // Move ���¿����� �÷��̾ ���� �̵�
                if (player != null)
                {
                    currentPosition = new Vector2(transform.position.x, transform.position.y);
                    playerPosition = new Vector2(player.position.x, player.position.y);

                    float step = 2f * Time.deltaTime;
                    transform.position = Vector2.MoveTowards(currentPosition, playerPosition, step);
                }
                break;

            case MonsterState.Attack:
                // Attack ���¿����� ���� ���� ����
                break;
        }
    }
}
