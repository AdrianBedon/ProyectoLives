using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hearts = 3;
    public int maxHearts = 5;
    [SerializeField] HeartSystem hs;

    public void Start()
    {
        hs.DrawHeart(hearts, maxHearts);
    }
    // Start is called before the first frame update
    public void TakeDamage(int d)
    {
        hearts -= d;
        hs.DrawHeart(hearts, maxHearts);
    }

    public void HealDamage(int d)
    {
        hearts += d;
        hs.DrawHeart(hearts, maxHearts);
    }
}
