using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider2D;
    
    public void StartAttack() 
    {
        StartCoroutine(Attack());
    }
    public IEnumerator Attack()
    {
        boxCollider2D.enabled = true;
        print("YES");
        yield return new WaitForSeconds(0.5f);
        boxCollider2D.enabled = false;
    }
}
