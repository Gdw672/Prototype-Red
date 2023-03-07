using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInformationService : IPlayerInformationService
{
    [Inject] private ICreaturesInfo creaturesInfo;
    public PlayerStats playerStats;

    public void SetStartPlayerStats()
    {
        var playerCreature = creaturesInfo.Creatures.Find(play => play.typeOfCreature == ETypeOfCreature.Player);
        playerStats = new PlayerStats();
        playerStats.Damage = playerCreature.Damage;
        playerStats.Health = playerCreature.HP;       
    }
    public void SetTransformOfPlayer(Transform transform)
    {
        playerStats.playerTranform = transform;
    }
    public PlayerStats GetInformationOfPlayer()
    {
        return playerStats;
    }
}

public interface IPlayerInformationService
{
    public void SetTransformOfPlayer(Transform transform);
    public PlayerStats GetInformationOfPlayer();
    public void SetStartPlayerStats();
} 
public class PlayerStats
{
    public Transform playerTranform;
    public int Health;
    public int Damage;
}