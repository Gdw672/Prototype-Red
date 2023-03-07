using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInformation : MonoBehaviour
{
    [Inject] private IPlayerInformationService _playerInformationService;

    private void Start()
    {
       /* _playerInformationService.SetStartPlayerStats();
        _playerInformationService.SetTransformOfPlayer(gameObject.transform);
        var x = _playerInformationService.GetInformationOfPlayer();
        print(x.Damage);*/
    }
}
