using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject Player;
    Vector2 Playerposition;
    private void Start()
    {
        Playerposition=Player.transform.position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Time.deltaTime * 10f);
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("Boom");

        }
    }
    void DesTroyGameObject()
    {
        Destroy(gameObject);
    }

}
