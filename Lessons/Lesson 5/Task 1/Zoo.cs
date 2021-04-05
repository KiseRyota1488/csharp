using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Zoo
    {
        public List<Animal> animal = new List<Animal>() { new Bear(), new Parrot() };
        public List<VideoCamera> cameras = new List<VideoCamera>() { new VideoCamera(), new VideoCamera() };
        public List<ZooWorker> zooWorkers = new List<ZooWorker>() { new ZooWorker(),new ZooWorker() };
    }
}
