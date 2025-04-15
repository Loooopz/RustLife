using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class HungerScript : MonoBehaviour
{

    float health = 100f;
    float thrist = 150f;
    float hunger = 200f;

    public float HungerSpeed = 1f;
    public float ThristSpeed = 1.5f;
    public float HealthPorogHegativnixEffectov = 1f;

    public Slider healthSlider;
    public Slider thristSlider;
    public Slider hungerSlider;

    public TMP_Text healthText;
    public TMP_Text thristText;
    public TMP_Text hungerText;
    void Update()
    {
         hunger -=  HungerSpeed * Time.deltaTime;
         thrist -= ThristSpeed * Time.deltaTime; 
         hungerSlider.value = hunger;
         thristSlider.value = thrist;
         hungerText.text = Mathf.RoundToInt(hunger).ToString();
         thristText.text = Mathf.RoundToInt(thrist).ToString();
         if (hunger <= 199f)
         {
             health -= 0.01f;
             healthSlider.value = health;
             healthText.text = Mathf.RoundToInt(health).ToString();
         }
         if (thrist <= 45f)
         {
             health -= 0.01f;
             healthSlider.value = health;
             healthText.text = Mathf.RoundToInt(health).ToString();
         }
         if (health <= 0)
         {
            print("YOU ARE DIE");
         }
    }
}
