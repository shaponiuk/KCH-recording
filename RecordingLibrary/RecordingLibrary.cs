using System;
using System.Collections.Generic;
using CSCore.CoreAudioAPI;

namespace RecordingLibrary
{
    public class Recording
    {
        public List<string> getDeviceList() {
            var deviceEnumerator = new MMDeviceEnumerator();
            var result = deviceEnumerator.EnumAudioEndpoints(DataFlow.Capture, DeviceState.Active);
            var returnList = new List<string>();
            foreach (var item in result) {
                returnList.Add(item.ToString());
            }
            return returnList;
        }
    }
}
