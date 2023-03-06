using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ScriptableObject", order = 0)]
public class CreaturesInfo : ScriptableObject, ICreaturesInfo
{
    [SerializeField] public List<Creature> creatures;
    public List<Creature> Creatures => creatures;
}

public enum ETypeOfCreature
{
   Player,
   DefaultEnemy
}

[Serializable]
public class Creature
{
    public ETypeOfCreature typeOfCreature;
    public int HP;
    public int Damage;
}

internal interface ICreaturesInfo
{
    List<Creature> Creatures { get; }
}