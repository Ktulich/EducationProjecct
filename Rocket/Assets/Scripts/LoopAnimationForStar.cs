using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAnimationForStar : MonoBehaviour
{
    private Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        anim.Play("AnimationForStar");
    }
}
