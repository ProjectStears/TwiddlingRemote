﻿using UnityEngine;
using System.Collections;

public class Sender : MonoBehaviour
{
    private string url = "http://aspepex.net/twiddle/setdata-34g0234knas.php";

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void Begin()
    {
        StartCoroutine(BeginCr());
    }

    private IEnumerator BeginCr()
    {
        WWWForm form = new WWWForm();
        form.AddField("command", "Loslaufen");

        WWW www = new WWW(url, form);
        yield return www;
    }

    public void Warn()
    {
        StartCoroutine(WarnCr());
    }
    private IEnumerator WarnCr()
    {
        WWWForm form = new WWWForm();
        form.AddField("command", "Warnung");

        WWW www = new WWW(url, form);
        yield return www;
    }


    public void Crash()
    {
        StartCoroutine(CrashCr());
    }

    private IEnumerator CrashCr()
    {
        WWWForm form = new WWWForm();
        form.AddField("command", "Crash");

        WWW www = new WWW(url, form);
        yield return www;
    }


    public void NoCrash()
    {
        StartCoroutine(NoCrashCr());
    }

    private IEnumerator NoCrashCr()
    {
        WWWForm form = new WWWForm();
        form.AddField("command", "NoCrash");

        WWW www = new WWW(url, form);
        yield return www;
    }


    public void Custom()
    {
        StartCoroutine(CustomCr());
    }

    private IEnumerator CustomCr()
    {
        WWWForm form = new WWWForm();
        form.AddField("command", "Custom");

        WWW www = new WWW(url, form);
        yield return www;
    }


    public void End()
    {
        StartCoroutine(EndCr());
    }

    private IEnumerator EndCr()
    {
        WWWForm form = new WWWForm();
        form.AddField("command", "Ende");

        WWW www = new WWW(url, form);
        yield return www;
    }
}