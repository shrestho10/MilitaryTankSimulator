﻿using System.Collections;

using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource shootBarrelGun;
    public AudioSource shellExplosion;

    public static SoundManager instance = null;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void ShootBarrelGun()
    {
        shootBarrelGun.Play();
    }
    public void ShellExplosion()
{
    shellExplosion.Play();
}
    // Update is called once per frame
   }
