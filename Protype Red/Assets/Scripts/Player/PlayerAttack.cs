using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider2D;
    bool attack;
    
    public void StartAttack() 
    {
        StartCoroutine(Attack());
    }
    public IEnumerator Attack()
    {
        if(!attack)
        {
            boxCollider2D.enabled = true;
            attack = true;
            yield return new WaitForSeconds(0.35f);
            attack = false;
            boxCollider2D.enabled = false;
        }
    }
}
