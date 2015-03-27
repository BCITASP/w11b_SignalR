using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace HitCounter
{
    public class HitCounterHub : Hub
    {
        static int _hitCount = 0;

        public void RecordHit()
        {
            _hitCount += 1;
            Clients.All.onRecordHit(_hitCount);
        }

    }
}