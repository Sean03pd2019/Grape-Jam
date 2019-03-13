using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

    public Sprite Pressed;
    public int playerWeight;
    public int necessaryWeight;

    [SerializeField] private PolygonCollider2D[] colliders;
    private int currentColliderIndex = 0;

    public void Start()
    {
        colliders[currentColliderIndex].enabled = true;
    }

    public void SetColliderForSprite(int spriteNum)
    {
        colliders[currentColliderIndex].enabled = false;
        currentColliderIndex = spriteNum;
        colliders[spriteNum].enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.Find("Player");
        PlayerWeight script = player.GetComponent<PlayerWeight>();
        playerWeight = script.weight;

        if (playerWeight >= necessaryWeight)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Pressed;
            SetColliderForSprite(1);
        }
    }
}
