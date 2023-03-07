using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class EnemySystemHP : MonoBehaviour
{
    [Inject] private ICreaturesInfo creaturesInfo;
    [Inject] private IPlayerInformationService _playerInformationService;
    private int hp;
    private Rigidbody2D _rigidbody2D;
    private Collider2D _attackPlayerCollder;

    private void Start()
    {
        hp = creaturesInfo.Creatures.Find(enemyStats => enemyStats.typeOfCreature == ETypeOfCreature.DefaultEnemy).HP;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerHit" && _attackPlayerCollder == null)
        {
            _attackPlayerCollder = collision;
            hp -= _playerInformationService.GetInformationOfPlayer().Damage;
           StartCoroutine (Impulse(_playerInformationService.GetInformationOfPlayer().playerTranform));
        }
    }

    public void FixedUpdate()
    {
        if (hp <= 0)
            Destroy(gameObject);
    }

    private IEnumerator Impulse(Transform transform)
    {
        _rigidbody2D.velocity = Vector2.zero;
        if (transform.position.x < gameObject.transform.position.x)
            _rigidbody2D.AddForce(Vector3.right * 0.2f, ForceMode2D.Impulse);
        else
            _rigidbody2D.AddForce(Vector3.left * 0.2f, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.6f);
        _attackPlayerCollder = null;
        yield return new WaitForSeconds(0.2f);
        _rigidbody2D.velocity = Vector2.zero;

    }
}
