using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformationService : IPlayerInformationService
{
    public PlayerStats ActualPlayerStats;
    public void GetTransformOfPlayer(Transform transform)
    {
        ActualPlayerStats.playerTranform = transform;
    }
    public PlayerStats GetInformationOfPlayer()
    {
        return ActualPlayerStats;
    }
    public void SetInformationOfPlayer(PlayerStats _playerStats)
    {
        this.ActualPlayerStats = _playerStats;
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