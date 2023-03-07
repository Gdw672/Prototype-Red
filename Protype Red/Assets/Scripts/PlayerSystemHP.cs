using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerSystemHP : MonoBehaviour
{
    [Inject] private IPlayerInformationService _playerInformationService;
    public PlayerStats playerStats;
    void Awake()
    {
        _playerInformationService.SetStartPlayerStats();
        _playerInformationService.SetTransformOfPlayer(gameObject.transform);
        playerStats = _playerInformationService.GetInformationOfPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
