using System;
using FileServiceLibrary;
using RecordingLibrary;

namespace MainLogicLibrary
{
    public class MainLogic
    {
        public void showFiles() {
            var fileService = new FileService();
            foreach (string fileName in fileService.getFileList()) {
                Console.WriteLine(fileName);
            }
        }

        public void showDirectories() {
            var fileService = new FileService();
            foreach (string dirName in fileService.getDirectoryList()) {
                Console.WriteLine(dirName);
            }
        }

        public void showAudioDevices() {
            var recObj = new Recording();
            foreach (string deviceName in recObj.getDeviceList()) {
                Console.WriteLine(deviceName);
            }
        }
    }
}
