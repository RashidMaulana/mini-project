using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;


    private void Start()
    {
        totalHealthBar.fillAmount = playerHealth.currentHealth;
    }


    private void Update()
    {
        currentHealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
}
