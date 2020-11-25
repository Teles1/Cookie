using System;
using System.Collections.Generic;
using Cookie.API.Game.Map.Elements;
using Cookie.API.Protocol.Network.Messages;

namespace Cookie.API.Game.Jobs
{
    public interface IGatherManager
    {
        bool Launched { get; }
        List<int> ToGather { get; }
        bool AutoGather { get; }
        void Stop();
        void DoAutoGather(bool arg);
        void Gather();
        void Gather(List<int> resourcesId, bool autoGather);
        bool CanGatherOnMap(List<int> ids);
        List<IUsableElement> TrierDistanceElement(List<int> listDistance,
            List<IUsableElement> listUsableElement);
    }
}