using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSprites : MonoBehaviour
{
    private Transform player;
    private SpriteRenderer thisSprite;
    private SpriteRenderer playerSprite;

    private Color color;

    [Header("时间控制参数")]
    public float activeTime;
    public float activeStart;


    [Header("不透明度参数")]
    private float alpha;
    public float alphaSet;//初始值
    public float alphaMultiplier;


    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform ;
        thisSprite = GetComponent<SpriteRenderer>();
        playerSprite = player.GetComponent<SpriteRenderer>();

        alpha = alphaSet;

        thisSprite.sprite = playerSprite.sprite;

        transform.position  = player.position;
        transform.localScale = player.localScale;
        transform.rotation = player.rotation;

        activeStart = Time.time;

    }
    // Update is called once per frame
    void Update()
    {
        alpha *= alphaMultiplier;
        color = new Color(1, 1, 1, alpha);
        thisSprite.color = color;

        if (Time.time >= activeStart + activeTime)
        {
            //返回对象池
            ShadowPool.instance.ReturnPool(this.gameObject);
        }
    }
}
