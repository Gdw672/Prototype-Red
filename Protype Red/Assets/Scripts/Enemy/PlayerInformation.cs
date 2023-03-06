using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInformation : MonoBehaviour
{
    [Inject] private IPlayerInformationService _playerInformationService;
    [SerializeField] private CreaturesInfo creaturesInfo;
    public static PlayerInformation Instance;
    PlayerStats _playerStats;

    private void Awake()
    {
        Instance = this;

        var playerStartInfo = creaturesInfo.creatures.Find(player => player.typeOfCreature == ETypeOfCreature.Player);

        _playerStats = new PlayerStats();
        _playerStats.playerTranform = gameObject.transform;
        _playerStats.Health = playerStartInfo.HP;
        _playerInformationService.SetInformationOfPlayer(_playerStats);
    }
}
