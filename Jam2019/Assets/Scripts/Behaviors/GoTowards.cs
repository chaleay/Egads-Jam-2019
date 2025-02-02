﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Behavior/Goto")]
public class GoTowards : FlockBehavior {

    //private Transform flockAgentTarget;
    [SerializeField] private float maxSpeed = 1f;

    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, FlockManager flockManager) {
        
        Vector3 targetDir = (agent.target.position - agent.transform.position).normalized;
        FindObjectOfType<FlockManager>().maxSpeed = maxSpeed;
        return targetDir;

    }
    
    
    
    
}
