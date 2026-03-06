using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
    }

    public void ChangeAmmoDisplay(int ammo, int maxAmmo)
    {
        currentAmmoText.text = ammo.ToString();
        maxAmmoText.text = maxAmmo.ToString();
    }

    public void ChangeHealthDisplay(float health, float maxHealth)
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
