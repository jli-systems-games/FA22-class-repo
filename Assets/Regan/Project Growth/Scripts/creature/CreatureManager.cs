using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

[RequireComponent(typeof(NetTime))]
public class CreatureManager : MonoBehaviour
{
    public GrowthStageBase currentStage;
    [SerializeField]
    private float _tickTime = 5;

    //creature stats
    public int age = 0;

    public int health = 180;
    public int maxHealth = 180;

    public int hunger = 3600;
    public int maxHunger = 3600;

    //dependencies
    private NetTime netTime;
    [SerializeField]
    private TextMeshProUGUI _debugCreatureStateText;

    //runtime
    private Coroutine _mainTickRoutine;

    private void Start()
    {
        netTime = GetComponent<NetTime>();
        netTime.getInternetTime(OnTimeReceived);
        
        ChangeStage(new EggStage(this));
        _mainTickRoutine = StartCoroutine(MainTick(_tickTime));
    }

    public void ChangeStage(GrowthStageBase growthStage)
    {
        currentStage = growthStage;
        growthStage.StageStart();
        _debugCreatureStateText.text = currentStage.GetType().ToString().Split("Stage")[0];
    }

    private void OnTimeReceived(string time)
    {
        Debug.Log(time);
    }

    private IEnumerator MainTick(float deltaTime)
    {
        YieldInstruction waitTimeInstruction = new WaitForSeconds(deltaTime);

        while (true)
        {
            currentStage.Tick();
            yield return waitTimeInstruction;
        }
    }

    
}


