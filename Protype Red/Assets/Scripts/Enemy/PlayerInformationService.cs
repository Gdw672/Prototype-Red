using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformationService : IPlayerInformationService
{
    public PlayerStats _playerStats;
    public void GetTransformOfPlayer(Transform transform)
    {
        _playerStats.playerTranform = transform;
    }
    public PlayerStats GetInformationOfPlayer()
    {
        return _playerStats;
    }
    public void SetInformationOfPlayer(PlayerStats _playerStats)
    {
        this._playerStats = _playerStats;
    }
}

public interface IPlayerInformationService
{
    public void GetTransformOfPlayer(Transform transform);
    public PlayerStats GetInformationOfPlayer();
    public void SetInformationOfPlayer(PlayerStats _playerStats);
    
} 
public class PlayerStats
{
    public Transform playerTranform;
    public int Health;
}