using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    [SerializeField] private Slider Healthbarslider;
    [SerializeField] private Slider Moneybarslider;

    private Entity money;
    private Hero hhhrrr;

    private void Start()
    {
        money = FindObjectOfType<Hero>();
        hhhrrr = FindObjectOfType<Hero>();
    }

    private void Update()
    {
            Healthbarslider.value = hhhrrr.lives;
            Moneybarslider.value = money.coinnumber;
    }
}
