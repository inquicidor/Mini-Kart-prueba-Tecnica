
using KartGame.KartSystems;
using UnityEngine;

public class SpeedPower : TargetObject
{

    public ArcadeKart card;
    void Start()
    {
        Register();
    }
        
    void OnCollect()
    {
        card.SpeedPower(speedPower);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("join");
        OnCollect();


    }

}
