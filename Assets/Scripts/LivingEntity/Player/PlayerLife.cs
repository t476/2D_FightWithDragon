using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife :LivingEntity
{
    public static PlayerLife instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    public override void TakenDamage(float _damageAmount)
    {
        base.TakenDamage(_damageAmount);
    }
}
