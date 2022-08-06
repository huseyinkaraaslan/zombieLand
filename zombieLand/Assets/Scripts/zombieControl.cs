using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieControl : MonoBehaviour
{
    private int zombieHP = 100;
    bool zombieDead;
    Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(zombieHP == 0)
        {
            zombieDead = true;
        }
        if(zombieDead == true)
        {
            animation.SetBool("dead", zombieDead);
            StartCoroutine(destroyZombie());
        }
    }

    public void hasarAl()
    {
        zombieHP -= Random.Range(15, 20);
    }

    IEnumerator destroyZombie()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
