﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController
{
    private ModelCtrl m_ModelController;
    private TrailCurveDrawCtrl m_TrailController;

    public PlayController(GameObject model)
    {
        Init(model);
    }

    private bool Init(GameObject model)
    {
        m_ModelController = new ModelCtrl(model);
        m_TrailController = new TrailCurveDrawCtrl();
        return true;
    }

    public void Update(ModelCtrlData modelCtrlData)
    {
        m_ModelController.MoveModel(modelCtrlData);
        m_TrailController.RecvTrailData(modelCtrlData);
    }

    public void SwitchTrail(TrailType trailType,bool IsOn)
    {
        m_TrailController.SwitchTrailCurve(trailType, IsOn);
    }
}
