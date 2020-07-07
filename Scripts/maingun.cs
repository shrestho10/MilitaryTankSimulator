using System.Collections;

using UnityEngine;

using UnityEngine.UI;

public class maingun : MonoBehaviour
{
   
    public int timeBetweenShots = 6;
    int shotTimer;
    public float force;
    public Transform barrelEnd;
    public Rigidbody shellPrefab;
    public Button shootButton;
    public Image shootButtonImage;
    public Text shootButtonText;

    void Awake()
    {
     
        ResetGun();
    }

    public void  values(float val)
    {
        force = val;
    }
    public void shootGun()
    {
       
        StartCoroutine("CoShoot");
    }

    public void ResetGun()
    {
        
        shootButton.interactable = true;
        shootButtonImage.color = Color.green;
        shootButtonText.text = ("shoot");
    }

    IEnumerator CoShoot()
    {
        SoundManager.instance.ShellExplosion();
        shootButton.interactable = false;
        shootButtonImage.color = Color.red;
        Rigidbody shell = Instantiate(shellPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        shell.velocity = -force * barrelEnd.forward;
        shotTimer = timeBetweenShots;
        while (shotTimer > 0)
        {
            shootButtonText.text = ("" + shotTimer);
            yield return new WaitForSeconds(1f);
            shotTimer--;
        }
        shootButton.interactable = true;
        shootButtonImage.color = Color.green;
        shootButtonText.text = ("shoot");
    }
}

 
