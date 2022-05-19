using UnityEngine;

public class BossLife : LivingEntity
{
    public static BossLife instance;
    public HealthBar healthBar;
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
    public override void TakenHit(float damage, Vector3 hitPoint, Vector3 hitDirection)
    {
        //AudioManager.instance.PlaySound("Impact", transform.position);//打到了
        GetComponentInChildren<HealthBar>().UpdateHp();
        Debug.Log("是不是没执行");
        if (damage >= health)
        {
           // AudioManager.instance.PlaySound("EnemyDeath", transform.position);
           //Destroy(Instantiate(deatheffect, hitPoint, Quaternion.FromToRotation(Vector3.forward, hitDirection)) as GameObject, 2f);
        }
        base.TakenHit(damage, hitPoint, hitDirection);
    }
}