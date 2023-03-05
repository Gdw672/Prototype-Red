using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInformation : MonoBehaviour
{
    [Inject] private IPlayerInformationService _playerInformationService;
    public static PlayerInformation Instance;
    PlayerStats _playerStats;

    private void Awake()
    {
        Instance = this;
        _playerStats = new PlayerStats();
        _playerStats.playerTranform = gameObject.transform;
        _playerStats.Health = 3;
        _playerInformationService.SetInformationOfPlayer(_playerStats);
    }
}
