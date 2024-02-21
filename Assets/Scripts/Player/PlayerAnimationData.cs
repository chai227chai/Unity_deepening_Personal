using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerAnimationData
{
    [SerializeField] private string groundParameterName = "@Ground";
    [SerializeField] private string idleParameterName = "Idle";
    [SerializeField] private string walkParameterName = "Walk";
    [SerializeField] private string runParameterName = "Run";

    [SerializeField] private string airParameterName = "@Air";
    [SerializeField] private string jumpParameterName = "Jump";
    [SerializeField] private string fallParameterName = "Fall";

    public int GroundParameter { get; private set; }
    public int IdleParameter { get; private set; }
    public int WalkParameter { get; private set; }
    public int RunParameter { get; private set; }

    public int AirParameter { get; private set; }
    public int JumpParameter { get; private set; }
    public int FallParameter { get; private set; }

    public void Initialize()
    {
        GroundParameter = Animator.StringToHash(groundParameterName);
        IdleParameter = Animator.StringToHash(idleParameterName);
        WalkParameter = Animator.StringToHash(walkParameterName);
        RunParameter = Animator.StringToHash(runParameterName);

        AirParameter = Animator.StringToHash(airParameterName);
        JumpParameter = Animator.StringToHash(jumpParameterName);
        FallParameter = Animator.StringToHash(fallParameterName);

    }

}
