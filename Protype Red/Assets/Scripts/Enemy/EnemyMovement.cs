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

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(gameObject.transform.position, playerStats.playerTranform.position, 0.003f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerHit")
            Destroy(gameObject);
    }
}
