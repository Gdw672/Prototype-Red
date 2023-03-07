using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyMovement : MonoBehaviour
{
    [Inject] private IPlayerInformationService _playerInformationService;
    PlayerStats playerStats;
    void Start()
    {
        playerStats = _playerInformationService.GetInformationOfPlayer();
    }

    private void OnEnable()
    {
        playerStats = _playerInformationService.GetInformationOfPlayer();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
          transform.position = Vector3.MoveTowards(gameObject.transform.position, playerStats.playerTranform.position, 0.009f);
    }
}
