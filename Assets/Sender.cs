using UnityEngine;
using System.Collections;

public class Sender : MonoBehaviour
{
    private string url = "http://aspepex.net/twiddle/setdata-34g0234knas.php";

    private string idleurl = "http://aspepex.net/twiddle/twiddledata-23we4asdg76.txt";

    private string starturl = "http://aspepex.net/twiddle/setbegin-34g0234knas.php";
    private string warnurl = "http://aspepex.net/twiddle/setwarn-34g0234knas.php";
    private string crashurl = "http://aspepex.net/twiddle/setcrash-34g0234knas.php";
    private string nocrashurl = "http://aspepex.net/twiddle/setnocrash-34g0234knas.php";
    private string customurl = "http://aspepex.net/twiddle/setcustom-34g0234knas.php";
    private string endurl = "http://aspepex.net/twiddle/setend-34g0234knas.php";

    private int lastSecond;

    private WWW idlePoller;

    private WWW startWww;
    private WWW warnWww;
    private WWW crashWww;
    private WWW nocrashWww;
    private WWW customWww;
    private WWW endWww;

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        idlePoller = new WWW(idleurl);
    }

    void Update()
    {
        int thissecond = Mathf.RoundToInt(Time.deltaTime);

        if (lastSecond != thissecond && idlePoller.isDone)
        {
            lastSecond = thissecond;
            StartCoroutine(IdlePoll());
        }
    }

    IEnumerator IdlePoll()
    {
        idlePoller = new WWW(idleurl);
        yield return idlePoller;
    }

    public void Begin()
    {
        StartCoroutine(BeginCr());
    }

    private IEnumerator BeginCr()
    {
        startWww = new WWW(starturl);
        yield return startWww;
    }

    public void Warn()
    {
        StartCoroutine(WarnCr());
    }

    private IEnumerator WarnCr()
    {
        warnWww = new WWW(warnurl);
        yield return warnWww;
    }


    public void Crash()
    {
        StartCoroutine(CrashCr());
    }

    private IEnumerator CrashCr()
    {
        crashWww = new WWW(crashurl);
        yield return crashWww;
    }


    public void NoCrash()
    {
        StartCoroutine(NoCrashCr());
    }

    private IEnumerator NoCrashCr()
    {
        nocrashWww = new WWW(nocrashurl);
        yield return nocrashWww;
    }


    public void Custom()
    {
        StartCoroutine(CustomCr());
    }

    private IEnumerator CustomCr()
    {
        customWww = new WWW(customurl);
        yield return customWww;
    }


    public void End()
    {
        StartCoroutine(EndCr());
    }

    private IEnumerator EndCr()
    {
        endWww = new WWW(endurl);
        yield return endWww;
    }
}
