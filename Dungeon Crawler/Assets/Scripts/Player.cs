using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] 
    private SpriteRenderer playerRenderer;

    private PlayerData dataPlayer;

    public void ApplyDataPlayer(PlayerData data)
    {
        dataPlayer = data;
        playerRenderer.sprite = data.imagePlayer;
    }
}
