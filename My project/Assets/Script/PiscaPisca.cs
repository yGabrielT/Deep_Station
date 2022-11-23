using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiscaPisca : MonoBehaviour
{
    public Light luz;
    public AnimationCurve animationCurve;
    public WrapMode wrapmode = WrapMode.PingPong;

    void Start()
    {
        this.animationCurve.postWrapMode = this.wrapmode;

    }
    void Update()
    {
        float value = animationCurve.Evaluate(Time.time);
        this.luz.intensity = value;
    }
}
