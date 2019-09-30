﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cross;
using GameFramework;
namespace MuGame
{
    class GRUsrplayerAvatar:GrPlayerAvatar
    {
        public GRUsrplayerAvatar(muGRClient ctrl)
            : base(ctrl)
        { }
        public static IObjectPlugin create(IClientBase m)
        {
            return new GRUsrplayerAvatar(m as muGRClient);
        }

        override protected void onLoadFin()
        {
            SkAniMeshImpl m = (m_gr as GRCharacter3D).skmesh as SkAniMeshImpl;
            m.addScript("player(Clone)", "FightAniUserTempSC");
        }
    }
}
