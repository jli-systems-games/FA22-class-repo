using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
using System.Globalization;

[RequireComponent(typeof(NetTime))]
public class CreatureManager : MonoBehaviour
{
    [SerializeField]
    private bool newSave = false;

    public GrowthStageBase currentStage;
    [SerializeField]
    private int _tickTime = 5;

    //creature stats
    public int age = 0;

    public int health = 180;
    public int maxHealth = 180;

    public int hunger = 3600;
    public int maxHunger = 3600;

    public bool lights = true;

    //dependencies
    private NetTime netTime;
    [SerializeField]
    private TextMeshProUGUI _debugCreatureStateText;
    [SerializeField]
    private TextMeshProUGUI _debugHungerText;
    [SerializeField]
    private RectTransform _hungerBar;
    [SerializeField]
    private Image _imageRenderer;
    [SerializeField]
    private Image _darkImageRenderer;
    [SerializeField]
    private GrowthStageBase _deadStage;

    //runtime
    private Coroutine _mainTickRoutine;

    private void Start()
    {
        if (newSave)
        {
            ResetState();
        }
        else
        {
            LoadState();
        }
        

        netTime = GetComponent<NetTime>();
        //netTime.getInternetTime(OnStartTimeReceived);
        
        ChangeStage(currentStage);
        StartMain();
        
    }

    private void StartMain()
    {
        _mainTickRoutine = StartCoroutine(MainTick(_tickTime));
    }

    public void ChangeStage(GrowthStageBase growthStage)
    {
        currentStage = growthStage;
        growthStage.StageStart(this);
        _debugCreatureStateText.text = (age/20).ToString();
    }

    public void ChangeSprite(Sprite newSprite)
    {
        _imageRenderer.sprite = newSprite;
    }

    public void Feed(int amount)
    {
        if (!currentStage.canFeed) { return; }
        ChangeHunger(amount);
        RefreshUI();
    }

    public void ToggleLights()
    {
        lights = !lights;
        
        RefreshUI();
    }

    public void Die()
    {
        ChangeStage(_deadStage);
    }

    public void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
    }

    public void ChangeHunger(int amount)
    {
        hunger = Mathf.Clamp(hunger + amount, 0, maxHunger);
    }

    private void OnStartTimeReceived(string date)
    {
        
        int tickDelta =(int) GetTicksOffline(date);

        StartCoroutine(CatchupTick(tickDelta / _tickTime));
        Debug.Log(tickDelta);
    }

    private void OnSaveTimeReceived(string date)
    {
        Debug.Log(date);
        PlayerPrefs.SetString("date", date);
    }

    private void Tick()
    {
        currentStage.Tick();
        RefreshUI();
    }

    private void RefreshUI()
    {
        
        _darkImageRenderer.enabled = !lights;
        _hungerBar.sizeDelta = new Vector2(hunger * 2 , 16);
    }

    private IEnumerator CatchupTick(int missedTicks)
    {
        YieldInstruction waitTimeInstruction = null;

        if (missedTicks != 0)
        {
            waitTimeInstruction = new WaitForSeconds(5 / missedTicks);
        }

        for (int i = 0; i < missedTicks; i++)
        {
            Tick();
            yield return waitTimeInstruction;
        }

        SaveState();
    }

    private IEnumerator MainTick(float deltaTime)
    {
        YieldInstruction waitTimeInstruction = new WaitForSeconds(deltaTime);

        while (true)
        {
            Tick();
            yield return waitTimeInstruction;
        }
    }

    private void ResetState()
    {
        PlayerPrefs.DeleteAll();
    }

    private void SaveState()
    {
        PlayerPrefs.SetInt("age", age);
        PlayerPrefs.SetInt("health", health);
        PlayerPrefs.SetInt("hunger", hunger);
        PlayerPrefs.SetInt("lights", lights ? 1 : 0);
        Debug.Log("saving");
        netTime.getInternetTime(OnSaveTimeReceived);
    }

    private void LoadState()
    {
        age = PlayerPrefs.GetInt("age");
        health = PlayerPrefs.GetInt("health");
        hunger = PlayerPrefs.GetInt("hunger");
        lights = PlayerPrefs.GetInt("lights") == 1;
        RefreshUI();
    }

    private void OnApplicationQuit()
    {
        SaveState();
    }

    private long GetTicksOffline(string date)
    {
        if (!PlayerPrefs.HasKey("date")) { return -1; }

        long newTicks = GetDateTime(date).Ticks;
        long oldTicks = GetDateTime(PlayerPrefs.GetString("date")).Ticks;

        return newTicks - oldTicks;

    }

    private DateTime GetDateTime(string date)
    {
        return DateTime.ParseExact(date, "ddd  DD MMM yyyy HH:mm:ss", CultureInfo.CurrentCulture);
    }
}


