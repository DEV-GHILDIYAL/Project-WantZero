using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MapTile : MonoBehaviour
{
    public PlayerController player;
    public byte moveSpeed;
    public LevelGenerator levelGenerator;

    private void Start()
    {
        player = FindAnyObjectByType<PlayerController>();
        levelGenerator = FindAnyObjectByType<LevelGenerator>();
    }
    private void FixedUpdate()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }
    private void OnTriggerExit(Collider other)
    {
        levelGenerator.SpawnEndlessTile();
        player.score += 1;
        if(player.score < player.lowscore)
        {
            SaveSystem.SavePlayer(player);
        }
        Destroy(gameObject, 2);
    }
}
