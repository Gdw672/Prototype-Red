using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerSystemHP : MonoBehaviour
{
    [Inject] private IPlayerInformationService _playerInformationService;
    PlayerStats playerStats;
    IEnumerator Start()
    {
      playerStats = _playerInformationService.GetInformationOfPlayer();

        for (int i = 0; i < 3; i++)
        {
            print(playerStats.Health);
            yield return new WaitForSeconds(3f);
            playerStats.Health -= 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
