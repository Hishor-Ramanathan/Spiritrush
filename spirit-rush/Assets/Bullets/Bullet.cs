using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hitEffect;
    public Bullets bullets;
    public float collisions = 0;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collisions == bullets.pierce)
        {
           
            Destroy(gameObject);
            if (!(hitEffect==null))
            {
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                effect.transform.localScale = effect.transform.localScale*bullets.size;
                Destroy(effect, 2f);
            }
           
            
        }
        collisions++;
        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }





}
