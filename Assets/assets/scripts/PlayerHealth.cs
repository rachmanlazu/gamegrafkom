﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float nyawaPenuh;
    float nyawaSekarang;

    public GameObject playerDeathFX;

    //HUD
    public Slider sliderNyawaPlayer;
    public Image damageScreen;
    Color flashColor = new Color(255f, 255f, 255f, 1f);
    float flashSpeed = 5f;
    bool damaged = false;

    // Use this for initialization
    void Start()
    {
        nyawaSekarang = nyawaPenuh;
        sliderNyawaPlayer.maxValue = nyawaPenuh;
        sliderNyawaPlayer.value = nyawaSekarang;
    }

    // Update is called once per frame
    void Update()
    {
        //muncul UI bercak darah sesaat saat terserang/damaged=true
        if (damaged){
            damageScreen.color = flashColor;
        }
        else{
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
     }

    public void addDamage(float damage)
    {
        nyawaSekarang -= damage;
        sliderNyawaPlayer.value = nyawaSekarang;
        damaged = true;
        if (nyawaSekarang <= 0){
            makeDead();
        }
    }

    public void makeDead(){
        Instantiate(playerDeathFX, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
        damageScreen.color = flashColor;    //muncul UI bercak darah (tidak langsung hilang) saat mati
        Destroy(gameObject);
    }
}
